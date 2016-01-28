using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DSDecmp.Formats.Nitro;

namespace SOSSE
{
    public partial class MainForm : Form
    {
        // Forms that is hidden when closing
        //private ItemEditingForm itemEditingForm;
        private const long saveLength_USA = 0x51FB8;
        private const int headerLength_USA = 0x48;
        private const long saveLength_EUR = 0x524F8;
        private const int headerLength_EUR = 0x58;


        public static byte[] Header;
        public static byte[] SaveData;

        // Default parameters
        public static readonly DataGridViewCellStyle GrayCellStyle;

        static MainForm()
        {
            GrayCellStyle = new DataGridViewCellStyle();
            GrayCellStyle.BackColor = Color.LightGray;
        }

        public MainForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        private void enableButtons()
        {
            saveAsButton.Enabled = true;
            itemButton.Enabled = true;
            objectButton.Enabled = false;
            shipLogButton.Enabled = false;
            balanceButton.Enabled = true;
            blueprintButton.Enabled = false;
            conquestButton.Enabled = false;
            shopButton.Enabled = false;
            animalButton.Enabled = false;
            patternButton.Enabled = false;
            recipeButton.Enabled = false;
            vendorButton.Enabled = false;
            npcButton.Enabled = false;
            generalButton.Enabled = true;
            eventButton.Enabled = false;
        }

        public void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            // Open a decompressed save file, for testing purpose
            if (new FileInfo(openFileDialog.FileName).Length == 0x51FB8)
            {
                Header = null;
                SaveData = File.ReadAllBytes(openFileDialog.FileName);
                enableButtons();
                return;
            }

            byte[] rawSave = File.ReadAllBytes(openFileDialog.FileName);
            if (rawSave[0x58] != 0x11)
            {
                MessageBox.Show("Invalid save file", "Error");
                return;
            }
            byte[] compressed = new byte[rawSave.Length - 0x58];
            Array.Copy(rawSave, 0x58, compressed, 0, rawSave.Length - 0x58);

            // Decompress
            byte[] decompressed = null;
            LZ11 lz11 = new LZ11();
            using (MemoryStream inStream = new MemoryStream(compressed))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    lz11.Decompress(inStream, compressed.Length, outStream);
                    if (outStream != null)
                        decompressed = outStream.ToArray();
                         
                    else
                    {
                        MessageBox.Show("Invalid save file", "Decompress Error");
                        return;
                    }
                }
                //only for testing
                /*
                using (FileStream fs = new FileStream("dec2.bin", FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        
                        bw.Write(decompressed);
                    }
                }
                 */
                
            }

            // Check file validity and save loading
            if (decompressed.Length != saveLength_EUR)
            {
                MessageBox.Show("Invalid save file", "Error");
                return;
            }

            // Check decompressed save file size
            /*
            string filesize = Convert.ToString(decompressed.Length);
            MessageBox.Show(filesize, "bytesize");
             */
             
            Header = new byte[0x58];
            Array.Copy(rawSave, 0, Header, 0, 0x58);
            SaveData = decompressed;
            enableButtons();
        }        

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary files (*.bin)|*.bin";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            //if (itemEditingForm != null) itemEditingForm.SaveItems();

            // For testing purpose
            if (Header == null)
            {
                File.WriteAllBytes(sfd.FileName, SaveData);
                return;
            }

            LZ11 lz11 = new LZ11();
            byte[] compressed;
            using (MemoryStream inStream = new MemoryStream(SaveData))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    lz11.Compress(inStream, SaveData.Length, outStream);
                    compressed = outStream.ToArray();
                }
            }
            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(Header);
                    bw.Write(compressed);
                }
            }
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            /*
            if (itemEditingForm == null)
                itemEditingForm = new ItemEditingForm();
                itemEditingForm.ShowDialog();
             */
            new ItemEditingForm.ShowDialog();
        }

        private void objectButton_Click(object sender, EventArgs e)
        {
            new ObjectEditingForm().ShowDialog();
        }

        private void shipLogButton_Click(object sender, EventArgs e)
        {
            new ShipLogEditingForm().ShowDialog();
        }

        private void blueprintButton_Click(object sender, EventArgs e)
        {
            new BlueprintEditingForm().ShowDialog();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            new BalanceForm().ShowDialog();
        }

        private void conquestButton_Click(object sender, EventArgs e)
        {
            new ConquestEditingForm().ShowDialog();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            new ShopEditingForm().ShowDialog();
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            new AnimalEditingForm().ShowDialog();
        }

        private void patternButton_Click(object sender, EventArgs e)
        {
            new PatternEditingForm().ShowDialog();
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            new RecipeEditingForm().ShowDialog();
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            new VendorEditingForm().ShowDialog();
        }

        private void npcButton_Click(object sender, EventArgs e)
        {
            new NPCEditingForm().ShowDialog();
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            new GeneralEditingForm().ShowDialog();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            new EventEditingForm().ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
