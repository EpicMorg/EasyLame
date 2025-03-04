using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLame
{
    public partial class FrmMain : Form
    {
        //
        // Global strings
        //

        string lameExe = "lame.exe";
        bool found = false;
        string systemPath = Environment.GetEnvironmentVariable("PATH");
        string lamePath;

        public FrmMain()
        {
            InitializeComponent();
            LameCheck();
        }
        private void LameCheck()
        {
            foreach (string path in systemPath.Split(Path.PathSeparator))
            {
                string fullPath = Path.Combine(path, lameExe);
                if (File.Exists(fullPath))
                {
                    found = true;
                    lamePath = fullPath;
                    break;
                }
            }

            // Если не найдено в системном пути, проверяем рядом с программой
            if (!found)
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localPath = Path.Combine(appDirectory, lameExe);
                if (File.Exists(localPath))
                {
                    found = true;
                    lamePath = localPath;
                }
            }

            // Если lame.exe не найден нигде, показываем сообщение
            if (!found)
            {
                toolStripStatusLabelLameBool.Text = "NOT Found";
                toolStripStatusLabelLameBool.ForeColor = Color.DarkRed;
                buttonBrowse.Enabled = true;
                groupBox.Enabled = false;
            }
            else
            {
                textBoxLamePath.Text = lamePath;
                toolStripStatusLabelLameBool.Text = "Found";
                toolStripStatusLabelLameBool.ForeColor = Color.DarkGreen;
                buttonBrowse.Enabled = false;
                groupBox.Enabled = true;

            }
        }

        private void RunLameProcess(string inputWavPath, string outputMp3Path)
        {
            try
            {
                // Создаем процесс для запуска lame.exe
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = lamePath,
                    Arguments = $"-b 320 \"{inputWavPath}\" \"{outputMp3Path}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit(); // Ждем завершения процесса

                    // Проверяем результат выполнения
                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Конвертация завершена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string error = process.StandardError.ReadToEnd();
                        MessageBox.Show($"Ошибка при конвертации: {error}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelDropToConvert_Click(object sender, EventArgs e)
        {
            // 1. Открываем диалог выбора WAV-файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV Files (*.wav)|*.wav";
                openFileDialog.Title = "Выберите WAV-файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string inputWavPath = openFileDialog.FileName;

                    // 2. Открываем диалог сохранения MP3-файла
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
                        saveFileDialog.Title = "Сохранить MP3-файл";
                        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(inputWavPath) + ".mp3";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string outputMp3Path = saveFileDialog.FileName;

                            // 3. Запускаем процесс lame.exe
                            RunLameProcess(inputWavPath, outputMp3Path);
                        }
                    }
                }
            }
        }
    }
}
