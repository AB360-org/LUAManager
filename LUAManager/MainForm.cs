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
            public static string classicKey = "55534361505170413454534E56784D49317639534B39554330795A75416E6232";
            public static string seasonsKey = "7A65506865737435666151755832533241707265403472654368417445765574";
            public static string rioKey = "55534361505170413454534E56784D49317639534B39554330795A75416E6232";
            public static string spaceKey = "526D67645A304A656E4C466757776B5976434C326C5361684662456846656334";
            public static string starWarsKey = "416E3874336D6E38553673706951307A4848723361316C6F44725261336D7445";
            public static string starWarsTwoKey = "4230706D3354416C7A6B4E3967687A6F65324E697A456C6C50644E3068516E69";
            public static string friendsKey = "454A52626357683831594734597A6A664C41504D7373416E6E7A785161446E31";

            public static ProcessStartInfo psi = new ProcessStartInfo();
            

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Info.whatWereDoing = "encrypt";
            encryptPanel.Visible = true;
            decryptPanel.Visible = false;
            decodePanel.Visible = false;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Info.whatWereDoing = "decrypt";
            encryptPanel.Visible = false;
            decryptPanel.Visible = true;
            decodePanel.Visible = false;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            Info.whatWereDoing = "decode";
            encryptPanel.Visible = false;
            decryptPanel.Visible = false;
            decodePanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            encryptGameSelect.SelectedIndex = 0;
            encryptInputFile.Text = "";
            encryptOutputFile.Text = "";
            decryptGameSelect.SelectedIndex = 0;
            decryptInputFile.Text = "";
            decryptOutputFile.Text = "";
            decodeInputFile.Text = "";
            decodeOutputFile.Text = "";

            fileRadio.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e) //Encrypt Input
        {
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                encryptInputFile.Text = openFileDialog1.FileName;
                encryptInputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                encryptInputFile.Text = folderBrowserDialog1.SelectedPath;
                encryptInputFile.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Encrypt Output
        {
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                encryptOutputFile.Text = saveFileDialog1.FileName;
                encryptOutputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                encryptOutputFile.Text = folderBrowserDialog2.SelectedPath;
                encryptOutputFile.Visible = true;
            }
        }
        public void OpenSSL(string parameters) //Run the OpenSSL program
        {
            Info.psi.FileName = Directory.GetCurrentDirectory() + "\\extras\\openssl.exe";
            Info.psi.UseShellExecute = false;
            Info.psi.CreateNoWindow = true;
            Info.psi.WindowStyle = ProcessWindowStyle.Hidden;
            Info.psi.Arguments = parameters;
            Process proc = Process.Start(Info.psi);
            proc.WaitForExit();
        }
        public void SevenZipFile(string arguments) //Run the 7-zip program
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
        public void Unluac(string inputFile, string outputFile) //Run the Unluac program
        {
            ProcessStartInfo java = new ProcessStartInfo();
            java.FileName = Directory.GetCurrentDirectory() + "\\extras\\decoder.bat";
            java.UseShellExecute = false;
            java.CreateNoWindow = true;
            java.WindowStyle = ProcessWindowStyle.Hidden;
            java.Arguments = "\"" + Directory.GetCurrentDirectory() + "\" \"" + inputFile + "\" \"" + outputFile + "\"";
            Process javaExe = Process.Start(java);
            javaExe.WaitForExit();
        }
        public void LZMA(string arguments) //Run the LZMA program
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
                return new[]{'j',};
            }
            
        }
        private void LetsGo_Click(object sender, EventArgs e)
        {
            string keyToUse = "";   
            SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\extras\\letsgo.wav");
            if (Info.whatWereDoing == "encrypt") //Encrypt functions
            {
                if (encryptGameSelect.SelectedIndex == 0)
                {
                    keyToUse = Info.classicKey;
                } 
                else if (encryptGameSelect.SelectedIndex == 1)
                {
                    keyToUse = Info.seasonsKey;
                }
                else if (encryptGameSelect.SelectedIndex == 2)
                {
                    keyToUse = Info.rioKey;
                }
                else if (encryptGameSelect.SelectedIndex == 3)
                {
                    keyToUse = Info.spaceKey;
                }
                else if (encryptGameSelect.SelectedIndex == 4)
                {
                    keyToUse = Info.starWarsKey;
                }
                else if (encryptGameSelect.SelectedIndex == 5)
                {
                    keyToUse = Info.starWarsTwoKey;
                }
                else if (encryptGameSelect.SelectedIndex == 6)
                {
                    keyToUse = Info.friendsKey;
                }
                else if (encryptGameSelect.SelectedIndex == 7)
                {
                    keyToUse = customKeyEnc.Text;
                }
                if (encryptInputFile.Text == "")
                {
                    MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to encrypt", "Please choose a folder",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (encryptOutputFile.Text == "")
                {
                    MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else if (encryptInputFile.Text == encryptOutputFile.Text)
                {
                    MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to a files while they're being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (encryptGameSelect.SelectedIndex == 7 && customKeyEnc.Text == "")
                {
                    MessageBox.Show("You need to paste a key into the box in order to use this option.", "No key entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    letsGoText.Text = "Getting ready to go, please wait...";
                    letsGoText.Visible = true;

                    FileInfo[] fileInfos =
                        (fileRadio.Checked)
                        ? (new FileInfo[] { new FileInfo(openFileDialog1.FileName) })
                        : (new DirectoryInfo(folderBrowserDialog1.SelectedPath)).GetFiles().Where(file => file.Extension == ".lua" || file.Extension == ".json").ToArray();

                    foreach (var file in fileInfos)
                    {
                        string savePath =
                            (fileRadio.Checked)
                            ? (saveFileDialog1.FileName)
                            : (folderBrowserDialog2.SelectedPath + "\\" + file.Name);

                        if (SevenZipCheck.Checked) //Put file in 7z archive if this is true
                        {

                            SevenZipFile("a -y " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.7z" + "\"" + " \"" + file.FullName + "\"");
                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.7z" + "\"" + " -out " + "\"" + savePath + "\"");
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.7z"))
                            {
                                File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.7z");
                            }
                        }
                        else if (LZMACheck.Checked) //Put file in LZMA archive if this true
                        {
                            LZMA("e " + "\"" + file.FullName + "\"" + " \"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"");

                            byte[] lzmaHeader = new byte[] { 0x89, 0x4C, 0x5A, 0x4D, 0x41, 0x0D, 0x0A, 0x1A, 0x0A }; //The header Angry Birds looks for to load a file
                            byte[] x = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"); //Read the contents of the file
                            byte[] byteLength = new byte[x.Length]; //Make an array the length of the file
                            byte[] temp = lzmaHeader.Concat(byteLength).ToArray();
                            long tempx = 9; //Temp counter
                            for (long i = 0; i < x.LongLength; i++)
                            {
                                temp[tempx] = x[i]; // The new array being filled with the data
                                tempx++; // The new array's counter
                            }
                            File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", temp); //Overwrite temp.bin again (assuming it's stored safely in RAM)

                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"" + " -out " + "\"" + savePath + "\"");
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"))
                            {
                                File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                            }
                        }
                        else //Assume the person is exporting a raw LUA for legacy AB versions
                        {
                            OpenSSL("enc -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + file.FullName + "\"" + " -out " + "\"" + savePath + "\"");
                        }
                    }
                    
                    
                    simpleSound.Play();
                    letsGoText.Text = "LET'S GOOO!";

                    string message =
                        (fileRadio.Checked)
                        ? ("The LUA file has been exported in encrypted form to\n" + saveFileDialog1.FileName + "!")
                        : ("All LUA files in " + folderBrowserDialog1.SelectedPath + " have been exported in encrypted form to\n" + folderBrowserDialog2.SelectedPath + "!");

                    MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    letsGoText.Visible = false;
                }
            }
            if (Info.whatWereDoing == "decrypt") //Decrypt functions
            {
                if (decryptGameSelect.SelectedIndex == 0)
                {
                    keyToUse = Info.classicKey;
                }
                else if (decryptGameSelect.SelectedIndex == 1)
                {
                    keyToUse = Info.seasonsKey;
                }
                else if (decryptGameSelect.SelectedIndex == 2)
                {
                    keyToUse = Info.rioKey;
                }
                else if (decryptGameSelect.SelectedIndex == 3)
                {
                    keyToUse = Info.spaceKey;
                }
                else if (decryptGameSelect.SelectedIndex == 4)
                {
                    keyToUse = Info.starWarsKey;
                }
                else if (decryptGameSelect.SelectedIndex == 5)
                {
                    keyToUse = Info.starWarsTwoKey;
                }
                else if (decryptGameSelect.SelectedIndex == 6)
                {
                    keyToUse = Info.friendsKey;
                }
                else if (decryptGameSelect.SelectedIndex == 7)
                {
                    keyToUse = customKeyDec.Text;
                }
                if (decryptInputFile.Text == "")
                {
                    MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to decrypt", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decryptOutputFile.Text == "")
                {
                    MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decryptInputFile.Text == decryptOutputFile.Text)
                {
                    MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to a files while they're being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decryptGameSelect.SelectedIndex == 7 && customKeyDec.Text == "")
                {
                    MessageBox.Show("You need to paste a key into the box in order to use this option.", "No key entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    letsGoText.Text = "Getting ready to go, please wait...";
                    letsGoText.Visible = true;

                    FileInfo[] fileInfos =
                        (fileRadio.Checked)
                        ? (new FileInfo[] { new FileInfo(openFileDialog1.FileName) })
                        : (new DirectoryInfo(folderBrowserDialog1.SelectedPath)).GetFiles().Where(file => file.Extension == ".lua" || file.Extension == ".json").ToArray();

                    foreach (var file in fileInfos)
                    {
                        string savePath =
                            (fileRadio.Checked)
                            ? (saveFileDialog1.FileName)
                            : (folderBrowserDialog2.SelectedPath + "\\" + file.Name);

                        OpenSSL("enc -d -K " + keyToUse + " -iv 00 -aes-256-cbc -in " + "\"" + file.FullName + "\"" + " -out " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"");
                        string header;
                        bool passed7zCheck = false;
                        if (autoUnzip.Checked) //Check if the file's first two bytes are "7z" and if so, unzip
                        {
                            header = ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 2)[0].ToString() + ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 2)[1];
                            if (header == "7z")
                            {
                                passed7zCheck = true; //To prevent LZMA function from running
                                SevenZipFile("e -y " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"" + " -o\"" + ((fileRadio.Checked) ? saveFileDialog1.FileName : folderBrowserDialog2.SelectedPath) + "\""); //Script no longer unzips 7z's into folders from this version on

                            }
                            else //File is not 7z, continue
                            {
                                if (autoUnlzma.Checked == false) //If this is checked, we leave the cleanup responsilbity to the autoUnlzma function
                                {
                                    File.Copy(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", savePath, true);
                                    if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"))
                                    {
                                        File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                                    }
                                }

                            }


                        }
                        if (autoUnlzma.Checked && passed7zCheck == false) //Check if the file's header is the magic number for LZMA encoding, and if so, decode
                        {
                            header = ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 5)[1].ToString() + ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 5)[2] + ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 5)[3] + ReadChars(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", 5)[4];
                            if (header == "LZMA")
                            {
                                //From www.codeproject.com

                                byte[] x = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"); //Read the contents of the file
                                byte[] temp = new byte[x.Length - 9]; //Make an array 9 bytes shorter than the original
                                long tempx = 0; //Temp counter
                                for (long i = 9; i < x.LongLength; i++) // Loop starts after the 9th byte
                                {
                                    temp[tempx] = x[i]; // The new array being filled with the data
                                    tempx++; // The new array's counter
                                }
                                File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", temp); //Overwrite temp.bin again (assuming it's stored safely in RAM
                                LZMA("d " + "\"" + Directory.GetCurrentDirectory() + "\\extras\\temp.bin" + "\"" + " \"" + savePath + "\""); //Decode from LZMA and export to save location
                            }
                            else
                            {
                                File.Copy(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", savePath, true);
                                if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"))
                                {
                                    File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                                }
                            }


                        }
                        if (autoUnzip.Checked == false && autoUnlzma.Checked == false)
                        {
                            File.Copy(Directory.GetCurrentDirectory() + "\\extras\\temp.bin", savePath, true);
                            if (File.Exists(Directory.GetCurrentDirectory() + "\\extras\\temp.bin"))
                            {
                                File.Delete(Directory.GetCurrentDirectory() + "\\extras\\temp.bin");
                            }
                        }

                    }

                    

                    simpleSound.Play();
                    letsGoText.Text = "LET'S GOOO!";

                    string message =
                        (fileRadio.Checked)
                        ? ("The LUA file has been exported in decrypted form to\n" + saveFileDialog1.FileName + "!")
                        : ("All LUA files in " + folderBrowserDialog1.SelectedPath + " have been exported in decrypted form to\n" + folderBrowserDialog2.SelectedPath + "!");

                    MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    letsGoText.Visible = false;
                }
            }
            if (Info.whatWereDoing == "decode") //Decode functions
            {
                if (decodeInputFile.Text == "")
                {
                    MessageBox.Show("You have not selected a " + ((fileRadio.Checked) ? "file" : "folder of files") + " to decode", "Please choose a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decodeOutputFile.Text == "")
                {
                    MessageBox.Show("You have not specified a " + ((fileRadio.Checked) ? "file" : "folder") + " to export to", "Please choose a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decodeInputFile.Text == decodeOutputFile.Text)
                {
                    MessageBox.Show("The input and output " + ((fileRadio.Checked) ? "file" : "folder") + " cannot be the same because you\ncannot write to a file while it is being read.", "Overwrite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    letsGoText.Text = "Getting ready to go, please wait...";
                    letsGoText.Visible = true;
                    bool passedTest = true;

                    FileInfo[] fileInfos =
                        (fileRadio.Checked)
                        ? (new FileInfo[] { new FileInfo(openFileDialog1.FileName) })
                        : (new DirectoryInfo(folderBrowserDialog1.SelectedPath)).GetFiles().Where(file => file.Extension == ".lua" || file.Extension == ".json").ToArray();

                    string lastFile = "";
                    foreach (var file in fileInfos)
                    {
                        string savePath =
                            (fileRadio.Checked)
                            ? (saveFileDialog1.FileName)
                            : (folderBrowserDialog2.SelectedPath + "\\" + file.Name);

                        //Check if the file's first 4 bytes contain the LUA header and if so, decode
                        {
                            string header = ReadChars(file.FullName, 4)[1].ToString() + ReadChars(file.FullName, 4)[2] + ReadChars(file.FullName, 4)[3];
                            if (header == "Lua")
                            {
                                Unluac(file.FullName, savePath);
                                lastFile = savePath;

                            }
                            else
                            {
                                MessageBox.Show("The file: \"" + file.FullName + "\" is not a valid binary LUA file.", "File is not valid or is encrypted", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("The AB360 LUA Manager was unable to decode your LUA file \"" + lastFile + "\". You could be missing some app files, or your JDK install is missing/corrupt.", "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                simpleSound.Play();
                                letsGoText.Text = "LET'S GOOO!";

                                string message =
                                    (fileRadio.Checked)
                                    ? ("The LUA file has been exported in decoded form to\n" + saveFileDialog1.FileName + "!")
                                    : ("All LUA files in " + folderBrowserDialog1.SelectedPath + " have been exported in decoded form to\n" + folderBrowserDialog2.SelectedPath + "!");

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


        }

        private void button3_Click(object sender, EventArgs e) //Decrypt Input
        {
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                decryptInputFile.Text = openFileDialog1.FileName;
                decryptInputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                decryptInputFile.Text = folderBrowserDialog1.SelectedPath;
                decryptInputFile.Visible = true;
            }
        }

        private void decryptOutputFileButton_Click(object sender, EventArgs e) //Decrypt Output
        {
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                decryptOutputFile.Text = saveFileDialog1.FileName;
                decryptOutputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                decryptOutputFile.Text = folderBrowserDialog2.SelectedPath;
                decryptOutputFile.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e) //Decode Input
        {
            if (fileRadio.Checked)
            {
                openFileDialog1.ShowDialog();
                decodeInputFile.Text = openFileDialog1.FileName;
                decodeInputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog1.ShowDialog();
                decodeInputFile.Text = folderBrowserDialog1.SelectedPath;
                decodeInputFile.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e) //Decode Ouput
        {
            if (fileRadio.Checked)
            {
                saveFileDialog1.ShowDialog();
                decodeOutputFile.Text = saveFileDialog1.FileName;
                decodeOutputFile.Visible = true;
            }
            else
            {
                folderBrowserDialog2.ShowDialog();
                decodeOutputFile.Text = folderBrowserDialog2.SelectedPath;
                decodeOutputFile.Visible = true;
            }
        }

        private void checkForFifthopt(object sender, EventArgs e)
        {
            if (decryptGameSelect.SelectedIndex == 7)
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
            if (encryptGameSelect.SelectedIndex == 7)
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

            encryptInputFile.Visible = false;
            encryptOutputFile.Visible = false;
            decryptInputFile.Visible = false;
            decryptOutputFile.Visible = false;
            decodeInputFile.Visible = false;
            decodeOutputFile.Visible = false;
        }

        private void fileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!fileRadio.Checked)
                return;

            ResetFileChoices();

            encryptInputLabel.Text = "File to be encrypted:";
            encryptOutputLabel.Text = "Output file:";
            encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA\r\ncompression.";

            decryptInputLabel.Text = "File to be decrypted:";
            decryptOutputLabel.Text = "Output file:";
            decryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA\r\ncompression.";

            decodeInputLabel.Text = "File to be decoded:";
            decodeOutputLabel.Text = "Output file:";
            decodeBrotipLabel.Text = "Brotip: Only decode the file if you know it's already decrypted\r\n";
        }

        private void folderRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!folderRadio.Checked)
                return;

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
        }
    }
}
