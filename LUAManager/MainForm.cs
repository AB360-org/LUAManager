using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace LUAManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static class Info
        {
            public static string whatWereDoing = "encrypt";
            public static ProcessStartInfo psi = new ProcessStartInfo();
        }
        private string GetKey(int selectedIndex, string customKey)
        {
            switch (selectedIndex)
            {
                case 0: return "55534361505170413454534E56784D49317639534B39554330795A75416E6232"; //classic
                case 1: return "7A65506865737435666151755832533241707265403472654368417445765574"; //seasons
                case 2: return "55534361505170413454534E56784D49317639534B39554330795A75416E6232"; //rio
                case 3: return "526D67645A304A656E4C466757776B5976434C326C5361684662456846656334"; //space
                case 4: return "416E3874336D6E38553673706951307A4848723361316C6F44725261336D7445"; //sw
                case 5: return "4230706D3354416C7A6B4E3967687A6F65324E697A456C6C50644E3068516E69"; //sw2
                case 6: return "454A52626357683831594734597A6A664C41504D7373416E6E7A785161446E31"; //friends
                case 7: return "34467A5A4F6165363079416D7854436C7A6467666372344241625049676A3758"; //stella
                case 8: return customKey;
                default: return string.Empty;
            }
        }
        private string GetDataKey(int selectedIndex, string customKey)
        {
            switch (selectedIndex)
            {
                case 0: return "3434695559356154726C61596F6574396C6170526C614B3145686C6563356930";
                case 1: return "62725534753D45625234735F41334150753655233742216178416D2A57652335";
                case 2: return "3434695559356154726C61596F6574396C6170526C614B3145686C6563356930";
                case 3: return "547065637A4B514C30374856645062565568417236466A55736D526374796335";
                case 4: return "653833547068305233615A326A474B3665533931754C7651704C3333767A4E69";
                case 5: return "74615433766967446F4E6C716434347969506274323162694370566D61366E62";
                case 6: return "584E334F436D55464C366B494E48756361325A514C3467714A67307231386F6C";
                case 7: return "426C6C33716B637935664B724E56785A71746B464831394F6A6E3273644A4675";
                case 8: return customKey;
                default: return string.Empty;
            }
        }

        private string GetCurrentKey(int selectedIndex, string customKey, bool isDataMode)
        {
            return isDataMode ? GetDataKey(selectedIndex, customKey) : GetKey(selectedIndex, customKey);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            bool encryptChecked = radioButtonEncrypt.Checked;
            encryptPanel.Visible = encryptChecked;
            decryptPanel.Visible = !encryptChecked;
            panelCrypt.Visible = true;
            decodePanel.Visible = false;
            Info.whatWereDoing = encryptChecked ? "encrypt" : "decrypt";
            assemblePanel.Visible = false;
            panelAssemble.Visible = false;
            disassemblePanel.Visible = false;
            assemblePanel.Visible = false;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            Info.whatWereDoing = "decode";
            encryptPanel.Visible = false;
            decryptPanel.Visible = false;
            panelCrypt.Visible = false;
            decodePanel.Visible = true;
            assemblePanel.Visible = false;
            disassemblePanel.Visible = false;
            panelAssemble.Visible = false;
        }
        private void radioButtonEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEncrypt.Checked)
            {
                Info.whatWereDoing = "encrypt";
                encryptPanel.Visible = true;
                decryptPanel.Visible = false;
                checkBoxDataMode.Visible = true;
                decodePanel.Visible = false;
            }
        }

        private void radioButtonDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecrypt.Checked)
            {
                Info.whatWereDoing = "decrypt";
                encryptPanel.Visible = false;
                decryptPanel.Visible = true;
                checkBoxDataMode.Visible = true;
                decodePanel.Visible = false;
            }

        }
        private void AssembleButton_Click(object sender, EventArgs e)
        {
            {
                bool assembleChecked = radioButtonAssemble.Checked;
                encryptPanel.Visible = false;
                decryptPanel.Visible = false;
                panelCrypt.Visible = false;
                decodePanel.Visible = false;
                Info.whatWereDoing = assembleChecked ? "assemble" : "disassemble";
                assemblePanel.Visible = assembleChecked;
                disassemblePanel.Visible = !assembleChecked;
                panelAssemble.Visible = true;
            }
        }
        private void radioButtonAssemble_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAssemble.Checked)
            {
                Info.whatWereDoing = "assemble";
                assemblePanel.Visible = true;
                disassemblePanel.Visible = false;
            }
        }
        private void radioButtonDisassemble_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDisassemble.Checked)
            {
                Info.whatWereDoing = "disassemble";
                assemblePanel.Visible = false;
                disassemblePanel.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Info.whatWereDoing = "encrypt";
            encryptGameSelect.SelectedIndex = 0;
            encryptInputFile.Text = "";
            encryptOutputFile.Text = "";
            decryptGameSelect.SelectedIndex = 0;
            decryptInputFile.Text = "";
            decryptOutputFile.Text = "";
            decodeInputFile.Text = "";
            decodeOutputFile.Text = "";
            labelAssembleInput.Text = "";
            labelAssembleOutput.Text = "";
            labelDisassembleInput.Text = "";
            labelDisassembleOutput.Text = "";

            fileRadio.Checked = true;
            radioButtonAssemble.Checked = true;
            radioButtonEncrypt.Checked = true;
            assemblePanel.Visible = false;
        }
        public void OpenSSL(string parameters)
        {
            Info.psi.FileName = Directory.GetCurrentDirectory() + "\\extras\\openssl.exe";
            Info.psi.UseShellExecute = false;
            Info.psi.CreateNoWindow = true;
            Info.psi.WindowStyle = ProcessWindowStyle.Hidden;
            Info.psi.Arguments = parameters;
            Process proc = Process.Start(Info.psi);
            proc.WaitForExit();
        }
        public void SevenZipFile(string arguments)
        {
            ProcessStartInfo sevenZip = new ProcessStartInfo();
            sevenZip.FileName = Directory.GetCurrentDirectory() + "\\extras\\7za.exe";
            sevenZip.UseShellExecute = false;
            sevenZip.CreateNoWindow = true;
            sevenZip.WindowStyle = ProcessWindowStyle.Hidden;
            sevenZip.Arguments = arguments;
            Process sevenZipExe = Process.Start(sevenZip);
            sevenZipExe.WaitForExit();
        }
        public void Unluac(string arguments, string file)
        {
            ProcessStartInfo java = new ProcessStartInfo();
            java.FileName = Directory.GetCurrentDirectory() + "\\extras\\" + file + ".bat";
            java.UseShellExecute = false;
            java.CreateNoWindow = true;
            java.WindowStyle = ProcessWindowStyle.Hidden;
            java.Arguments = arguments;
            Process javaExe = Process.Start(java);
            javaExe.WaitForExit();
        }
        public void LZMA(string arguments)
        {
            ProcessStartInfo lzmaProg = new ProcessStartInfo();
            lzmaProg.FileName = Directory.GetCurrentDirectory() + "\\extras\\lzma.exe";
            lzmaProg.UseShellExecute = false;
            lzmaProg.CreateNoWindow = true;
            lzmaProg.WindowStyle = ProcessWindowStyle.Hidden;
            lzmaProg.Arguments = arguments;
            Process lzmaProgExe = Process.Start(lzmaProg);
            lzmaProgExe.WaitForExit();
        }
        public void BatFile(string input, string output, string action, SoundPlayer simpleSound)
        {
            if (input == "")
            {
                MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to " + action, "Please choose a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (output == "")
            {
                MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (input == output)
            {
                MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to a file while it is being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                letsGoText.Text = "Getting ready to go, please wait...";
                letsGoText.Visible = true;
                bool passedTest = true;

                FileInfo[] fileInfos = (fileRadio.Checked)
                       ? new FileInfo[] { new FileInfo(openFileDialog1.FileName) }
                       : new DirectoryInfo(folderBrowserDialog1.SelectedPath)
                           .GetFiles("*.*", checkBoxFolderMode.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                           .Where(file => file.Extension.Equals(".lua", StringComparison.OrdinalIgnoreCase) ||
                                          file.Extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                           .ToArray();

                string sourceFolder = folderBrowserDialog1.SelectedPath;
                string targetFolder = folderBrowserDialog2.SelectedPath;
                string lastFile = "";
                foreach (var file in fileInfos)
                {
                    string savePath = (fileRadio.Checked)
                        ? saveFileDialog1.FileName
                        : (checkBoxFolderMode.Checked
                            ? Path.Combine(targetFolder, file.FullName.Substring(sourceFolder.Length).TrimStart('\\'))
                            : Path.Combine(targetFolder, file.Name));

                    if (!fileRadio.Checked && checkBoxFolderMode.Checked)
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                    }

                    {
                        string header = ReadChars(file.FullName, 4)[1].ToString() + ReadChars(file.FullName, 4)[2] + ReadChars(file.FullName, 4)[3];
                        if (((action == "decode" || action == "disassemble") & header == "Lua") || (action == "assemble" & header == "ver"))
                        {
                            Unluac("\"" + Directory.GetCurrentDirectory() + "\" \"" + file.FullName + "\" \"" + savePath + "\"", action);
                            lastFile = savePath;

                        }
                        else
                        {
                            MessageBox.Show("The file: \"" + file.FullName + "\" is not a valid file.", "File is not valid or is encrypted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            passedTest = false;
                        }

                    }

                }
                if (passedTest)
                {
                    if (File.Exists(lastFile))
                    {
                        FileInfo luaSize = new FileInfo(lastFile);
                        if (luaSize.Length == 0)
                        {
                            MessageBox.Show("The AB360 LUA Manager was unable to " + action + " your LUA file \"" + lastFile + "\". You could be missing some app files, or your JDK install is missing/corrupt.", "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            simpleSound.Play();
                            letsGoText.Text = "LET'S GOOO!";

                            string message =
                                (fileRadio.Checked)
                                ? ("The LUA file has been exported in " + action + "d form to\n" + saveFileDialog1.FileName + "!")
                                : ("All LUA files in " + folderBrowserDialog1.SelectedPath + " have been exported in " + action + "d form to\n" + folderBrowserDialog2.SelectedPath + "!");

                            MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A valid installation of the Java JDK could not be found, please install a copy of it in order to use this feature.", "Java JDK not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                letsGoText.Visible = false;
            }
        }
        public static char[] ReadChars(string filename, int count)
        {
            try
            {
                using (var stream = File.OpenRead(filename))
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    char[] buffer = new char[count];
                    int n = reader.ReadBlock(buffer, 0, count);

                    char[] result = new char[n];

                    Array.Copy(buffer, result, n);

                    return result;
                }
            }
            catch
            {
                MessageBox.Show("The input file does not exist.", "Please choose a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new[] { 'j', };
            }

        }
        private void LetsGo_Click(object sender, EventArgs e)
        {
            string keyToUse = "";
            SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\extras\\letsgo.wav");
            if (Info.whatWereDoing == "encrypt")
            {
                keyToUse = GetCurrentKey(encryptGameSelect.SelectedIndex, customKeyEnc.Text, checkBoxDataMode.Checked);
                if (encryptInputFile.Text == "")
                {
                    MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to encrypt", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (encryptOutputFile.Text == "")
                {
                    MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (encryptInputFile.Text == encryptOutputFile.Text)
                {
                    MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to a files while they're being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (encryptGameSelect.SelectedIndex == 8 && customKeyEnc.Text == "")
                {
                    MessageBox.Show("You need to paste a key into the box in order to use this option.", "No key entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    letsGoText.Text = "Getting ready to go, please wait...";
                    letsGoText.Visible = true;
                    FileInfo[] fileInfos = (fileRadio.Checked)
                        ? new FileInfo[] { new FileInfo(openFileDialog1.FileName) }
                        : new DirectoryInfo(folderBrowserDialog1.SelectedPath)
                            .GetFiles("*.*", checkBoxFolderMode.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                            .Where(file => file.Extension.Equals(".lua", StringComparison.OrdinalIgnoreCase) ||
                                           file.Extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                            .ToArray();

                    string sourceFolder = folderBrowserDialog1.SelectedPath;
                    string targetFolder = folderBrowserDialog2.SelectedPath;

                    foreach (var file in fileInfos)
                    {
                        string savePath = (fileRadio.Checked)
                            ? saveFileDialog1.FileName
                            : (checkBoxFolderMode.Checked
                                ? Path.Combine(targetFolder, file.FullName.Substring(sourceFolder.Length).TrimStart('\\'))
                                : Path.Combine(targetFolder, file.Name));

                        if (!fileRadio.Checked && checkBoxFolderMode.Checked)
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                        }
                        if (SevenZipCheck.Checked)
                        {
                            SevenZipFile("a -y " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.7z" + "\"" + " \"" + file.FullName + "\"");
                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.7z" + "\"" + " -out " + "\"" + savePath + "\"");
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.7z"))
                            {
                                File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.7z");
                            }
                        }
                        else if (LZMACheck.Checked)
                        {
                            LZMA("e " + "\"" + file.FullName + "\"" + " \"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"");

                            byte[] lzmaHeader = new byte[] { 0x89, 0x4C, 0x5A, 0x4D, 0x41, 0x0D, 0x0A, 0x1A, 0x0A };
                            byte[] x = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                            byte[] byteLength = new byte[x.Length];
                            byte[] temp = lzmaHeader.Concat(byteLength).ToArray();
                            long tempx = 9;
                            for (long i = 0; i < x.LongLength; i++)
                            {
                                temp[tempx] = x[i];
                                tempx++;
                            }
                            File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", temp);

                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"" + " -out " + "\"" + savePath + "\"");
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"))
                            {
                                File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                            }
                        }
                        else
                        {
                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + file.FullName + "\"" + " -out " + "\"" + savePath + "\"");
                        }
                    }

                    simpleSound.Play();
                    letsGoText.Text = "LET'S GOOO!";

                    string message = (fileRadio.Checked)
                        ? ("The LUA file has been exported in encrypted form to\n" + saveFileDialog1.FileName + "!")
                        : ("All LUA files in " + folderBrowserDialog1.SelectedPath + " have been exported in encrypted form to\n" + targetFolder + "!");

                    MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    letsGoText.Visible = false;
                }
            }
            if (Info.whatWereDoing == "decrypt")
            {
                keyToUse = GetCurrentKey(decryptGameSelect.SelectedIndex, customKeyDec.Text, checkBoxDataMode.Checked);
                if (decryptInputFile.Text == "")
                {
                    MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to decrypt", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (decryptOutputFile.Text == "")
                {
                    MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (decryptInputFile.Text == decryptOutputFile.Text)
                {
                    MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to files while they're being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (decryptGameSelect.SelectedIndex == 8 && customKeyDec.Text == "")
                {
                    MessageBox.Show("You need to paste a key into the box in order to use this option.", "No key entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                letsGoText.Text = "Getting ready to go, please wait...";
                letsGoText.Visible = true;
                FileInfo[] fileInfos = (fileRadio.Checked)
                    ? new FileInfo[] { new FileInfo(openFileDialog1.FileName) }
                    : new DirectoryInfo(folderBrowserDialog1.SelectedPath).GetFiles("*.*", checkBoxFolderMode.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Where(file => file.Extension.Equals(".lua", StringComparison.OrdinalIgnoreCase) || file.Extension.Equals(".json", StringComparison.OrdinalIgnoreCase)).ToArray();
                string sourceFolder = fileRadio.Checked
                    ? Path.GetDirectoryName(openFileDialog1.FileName)
                    : folderBrowserDialog1.SelectedPath;
                string targetFolder = fileRadio.Checked
                    ? Path.GetDirectoryName(saveFileDialog1.FileName)
                    : folderBrowserDialog2.SelectedPath;
                foreach (var file in fileInfos)
                {
                    string savePath;
                    if (fileRadio.Checked)
                    {
                        savePath = saveFileDialog1.FileName;
                    }
                    else
                    {
                        if (checkBoxFolderMode.Checked)
                        {
                            string relativePath = file.FullName.Substring(sourceFolder.Length).TrimStart('\\', '/');
                            savePath = Path.Combine(targetFolder, relativePath);
                            Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                        }
                        else
                        {
                            savePath = Path.Combine(targetFolder, file.Name);
                        }
                    }
                    string tempFilePath = Path.Combine(Directory.GetCurrentDirectory(), "extras", "temp.bin");
                    OpenSSL($"enc -d -K {keyToUse} -iv 00 -aes-256-cbc -in \"{file.FullName}\" -out \"{tempFilePath}\"");
                    bool processed = false;
                    if (autoUnzip.Checked)
                    {
                        string header = ReadChars(tempFilePath, 2)[0].ToString() + ReadChars(tempFilePath, 2)[1];
                        if (header == "7z")
                        {
                            processed = true;
                            SevenZipFile($"e -y \"{tempFilePath}\" -o\"{Path.GetDirectoryName(savePath)}\"");
                        }
                    }
                    if (autoUnlzma.Checked && !processed)
                    {
                        string header = ReadChars(tempFilePath, 5)[1].ToString() +
                                       ReadChars(tempFilePath, 5)[2] +
                                       ReadChars(tempFilePath, 5)[3] +
                                       ReadChars(tempFilePath, 5)[4];
                        if (header == "LZMA")
                        {
                            processed = true;
                            byte[] data = File.ReadAllBytes(tempFilePath);
                            byte[] newData = new byte[data.Length - 9];
                            Array.Copy(data, 9, newData, 0, newData.Length);
                            File.WriteAllBytes(tempFilePath, newData);
                            LZMA($"d \"{tempFilePath}\" \"{savePath}\"");
                        }
                    }
                    if (!processed)
                    {
                        File.Copy(tempFilePath, savePath, overwrite: true);
                    }
                    if (File.Exists(tempFilePath))
                    {
                        File.Delete(tempFilePath);
                    }
                }
                simpleSound.Play();
                letsGoText.Text = "LET'S GOOO!";
                string message = fileRadio.Checked
                    ? $"The LUA file has been exported in decrypted form to\n{saveFileDialog1.FileName}!"
                    : $"All LUA files in {folderBrowserDialog1.SelectedPath} have been exported in decrypted form to\n{targetFolder}!";
                MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                letsGoText.Visible = false;
            }
            if (Info.whatWereDoing == "decode")
            {
                BatFile(decodeInputFile.Text, decodeOutputFile.Text, "decode", simpleSound);
            }
            if (Info.whatWereDoing == "assemble")
            {
                BatFile(labelAssembleInput.Text, labelAssembleOutput.Text, "assemble", simpleSound);
            }
            if (Info.whatWereDoing == "disassemble")
            {
                BatFile(labelDisassembleInput.Text, labelDisassembleOutput.Text, "disassemble", simpleSound);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            encryptInputFile.Visible = true;
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                encryptInputFile.Text = openFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                encryptInputFile.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            encryptOutputFile.Visible = true;
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                encryptOutputFile.Text = saveFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                encryptOutputFile.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            decryptInputFile.Visible = true;
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                decryptInputFile.Text = openFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                decryptInputFile.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void decryptOutputFileButton_Click(object sender, EventArgs e)
        {
            decryptOutputFile.Visible = true;
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                decryptOutputFile.Text = saveFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                decryptOutputFile.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            decodeInputFile.Visible = true;
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                decodeInputFile.Text = openFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                decodeInputFile.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decodeOutputFile.Visible = true;
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                decodeOutputFile.Text = saveFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                decodeOutputFile.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void buttonAssembleInput_Click(object sender, EventArgs e)
        {
            labelAssembleInput.Visible = true;
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                labelAssembleInput.Text = openFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                labelAssembleInput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonAssembleOutput_Click(object sender, EventArgs e)
        {
            labelAssembleOutput.Visible = true;
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                labelAssembleOutput.Text = saveFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                labelAssembleOutput.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        private void buttonDisassembleInput_Click(object sender, EventArgs e)
        {
            labelDisassembleInput.Visible = true;
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                labelDisassembleInput.Text = openFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                labelDisassembleInput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonDisassembleOutput_Click(object sender, EventArgs e)
        {
            labelDisassembleOutput.Visible = true;
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                labelDisassembleOutput.Text = saveFileDialog1.FileName;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                labelDisassembleOutput.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        private void checkForFifthopt(object sender, EventArgs e)
        {
            if (decryptGameSelect.SelectedIndex == 8)
            {
                customKeyDec.Visible = true;
            }
            else
            {
                customKeyDec.Visible = false;
            }
        }

        private void IndexChangeEnc(object sender, EventArgs e)
        {
            if (encryptGameSelect.SelectedIndex == 8)
            {
                customKeyEnc.Visible = true;
            }
            else
            {
                customKeyEnc.Visible = false;
            }
        }

        private void ResetFileChoices()
        {
            encryptInputFile.Text = "";
            encryptOutputFile.Text = "";
            decryptInputFile.Text = "";
            decryptOutputFile.Text = "";
            decodeInputFile.Text = "";
            decodeOutputFile.Text = "";
            labelAssembleInput.Text = "";
            labelAssembleOutput.Text = "";
            labelDisassembleInput.Text = "";
            labelDisassembleOutput.Text = "";

            encryptInputFile.Visible = false;
            encryptOutputFile.Visible = false;
            decryptInputFile.Visible = false;
            decryptOutputFile.Visible = false;
            decodeInputFile.Visible = false;
            decodeOutputFile.Visible = false;
            labelAssembleInput.Visible = false;
            labelAssembleOutput.Visible = false;
            labelDisassembleInput.Visible = false;
            labelDisassembleOutput.Visible = false;
        }

        private void fileRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFolderMode.Visible = true;
            if (!fileRadio.Checked) return;
            checkBoxFolderMode.Visible = false;

            ResetFileChoices();

            encryptInputLabel.Text = "File to be encrypted:";
            encryptOutputLabel.Text = "Output file:";
            encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or \r\nLZMA compression.";

            decryptInputLabel.Text = "File to be decrypted:";
            decryptOutputLabel.Text = "Output file:";
            decryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or \r\nLZMA compression.";

            decodeInputLabel.Text = "File to be decoded:";
            decodeOutputLabel.Text = "Output file:";
            decodeBrotipLabel.Text = "Brotip: Only decode the file if you know it's already decrypted\r\n";

            label6.Text = "File to disassemble:";
            label10.Text = "Output file:";
            label3.Text = "Brotip: Only disassemble the file if you know it's already decrypted\r\n";

            label4.Text = "File to assemble:";
            label7.Text = "Output file:";
            label2.Text = "Brotip: Only assemble the file if you know it's already disassembled\r\n";
        }

        private void folderRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFolderMode.Visible = false;
            if (!folderRadio.Checked) return;
            checkBoxFolderMode.Visible = true;
            ResetFileChoices();

            encryptInputLabel.Text = "Encrypt files from:";
            encryptOutputLabel.Text = "Output to:";
            encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA\r\ncompression.";

            decryptInputLabel.Text = "Decrypt files from:";
            decryptOutputLabel.Text = "Output to:";
            decryptBrotipLabel.Text = "Brotip: Have 2 folders, one with the files to be decrypted, and another to send the files to.";

            decodeInputLabel.Text = "Decode files from:";
            decodeOutputLabel.Text = "Output to:";
            decodeBrotipLabel.Text = "Brotip: Make sure all LUA files in the folder are not encrypted before you continue\r\n";

            label6.Text = "Disassemble files from:";
            label10.Text = "Output to:";
            label3.Text = "Brotip: Make sure all LUA files in the folder are not encrypted or disassembled\r\n before you continue\r\n";

            label4.Text = "Assemble files from:";
            label7.Text = "Output to:";
            label2.Text = "Brotip: Make sure all LUA files in the folder are not encrypted or assembled\r\n before you continue\r\n";
        }
    }
}
