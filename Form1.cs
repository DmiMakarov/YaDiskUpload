using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace YaDiskUpload
{
    public partial class Form1 : Form
    {
        Requests request = new Requests();
        public Form1()
        {

            try
            {
                //Адаптировать расширение приложения
                DpiFix();
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                linkLabelAuth.Text = Constants.AuthAdress;
                string token = ConfigurationManager.AppSettings.Get("token");
                checkToken(token,true);
            }
            catch (Exception e)
            {
                string error_mess = $"When try to start form get error: {e.Message}";
                if (e.InnerException != null)
                {
                    error_mess += $", {e.InnerException.Message}";
                }
                error_mess += $" \n\t\tfrom method {e.TargetSite.ToString()}";
            }

        }

        private void linkLabelAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelAuth.Text);
        }

        private bool checkToken(string token,bool isFirst)
        {
            string test_response = request.GetTestRequest(token).GetAwaiter().GetResult();
            if (test_response != "")
            {
                GetUploadError response_obj = JsonSerializer.Deserialize<GetUploadError>(test_response);
                if(!isFirst)
                    MessageBox.Show($"При авторизации произошла ошибка:\n{response_obj.message}\n Проверьте правильность введённого кода", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                ConfigurationManager.AppSettings.Set("token", token);
                labelIsAuth.Text = "Авторизовано";
                return true;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            
            if(Int32.TryParse(textBoxCodeAuth.Text, out int port) && textBoxCodeAuth.Text.Length == 7)
            {
                var token = request.PostAuthCodeToToken(textBoxCodeAuth.Text).GetAwaiter().GetResult();
                checkToken(token,false);
            }
            else if (textBoxCodeAuth.Text.Length != 0)
            {
                checkToken(textBoxCodeAuth.Text,false);
            }
            else
            {
                MessageBox.Show("Неккоректный формат кода подтверждения", "Ошибка формата вводимых данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonBeginUpload_Click(object sender, EventArgs e)
        {
            string token = ConfigurationManager.AppSettings.Get("token");
            bool isDelete = checkBoxDelete.Checked;
            if (checkToken(token, false))
            {
                if (Directory.Exists(textBoxFilePath.Text))
                {
                    string[] files = Directory.GetFiles(textBoxFilePath.Text);
                    progressBar.Visible = true;
                    progressBar.Minimum = 1;
                    progressBar.Maximum = files.Length;
                    progressBar.Value = 1;
                    progressBar.Step = 1;
                    Dictionary<string, string> errors = new Dictionary<string, string>();
                    foreach (string file in files)
                    {
                        string response = request.GetFileUpload(file, textBoxFolderDisk.Text, token).GetAwaiter().GetResult();
                        if (response != "")
                        {
                            if (response == "507")
                            {
                                MessageBox.Show("Закончилось место на диске", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            errors.Add(file, response);
                        }
                        else
                        {
                            if (isDelete)
                            {
                                File.Delete(file);
                            }
                        }
                        progressBar.PerformStep();
                    }
                    int num_errors = errors.Count();
                    if (num_errors == 0)
                    {
                        MessageBox.Show("Загрузка файлов завершена", "Завершение загрузки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (num_errors == files.Length)
                    {
                        writeErrors(errors);
                        MessageBox.Show("Не удалось загрузить ни один файл.\n Для подробной информации просмотрите файл errors.txt в каталоге программы", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Dictionary<string, string> new_errors = new Dictionary<string, string>();
                        foreach (var error in errors)
                        {
                            string response = request.GetFileUpload(error.Key, textBoxFolderDisk.Text, token).GetAwaiter().GetResult();
                            if (response != "")
                            {
                                if (response == "507")
                                {
                                    MessageBox.Show("Закончилось место на диске", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                                new_errors.Add(error.Key, response);
                            }
                            else
                            {
                                File.Delete(error.Key);
                            }
                        }
                        if (new_errors.Count() == 0)
                        {
                            MessageBox.Show("Загрузка файлов завершена", "Завершение загрузки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            writeErrors(new_errors);
                            MessageBox.Show($"Не удалось загрузить {new_errors.Count()} файлов.\n Для подробной информации просмотрите файл errors.txt в каталоге программы", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Указанной папки не существует", "Ошибка открытия папки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Для начала необходимо авторизоваться", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public static void DpiFix()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        private void writeErrors(Dictionary<string,string> errors)
        {
            using (StreamWriter w = new StreamWriter(Directory.GetCurrentDirectory() + "\\errors.txt", false, Encoding.GetEncoding(1251)))
            {
                foreach(var error in errors)
                {
                    w.WriteLine($"{error.Key}: {error.Value}");
                }
            }
        }
    }
}
