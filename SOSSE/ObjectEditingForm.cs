﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOSSE
{
    public partial class ObjectEditingForm : Form
    {
        private const int objectOffset = 0x2B63A;

        public bool DataLoaded { get; private set; }
        public bool IsModified { get; private set; }

        public const int MaxObject = 1086;
        public const int MaxRealObject = 904;
        public static string[] ObjectNameList = null;
        #region public static readonly ushort[] ObjectSortedList
        public static readonly ushort[] ObjectSortedList = { 0x124, 0x23A,
            0x174, 0x117, 0x33D, 0x6D, 0x316, 0x382, 0x181, 0x78, 0x262, 0x125,
            0x15B, 0x2D7, 0x8, 0x6, 0x7, 0x163, 0x315, 0x116, 0x2F7, 0x41, 0x5E,
            0x50, 0x2D2, 0x2D1, 0x179, 0x311, 0x6F, 0x18F, 0x192, 0x18E, 0x191,
            0x18D, 0x190, 0x37C, 0x1BF, 0x1C2, 0x1BE, 0x1C1, 0x1BD, 0x1C0,
            0x375, 0x267, 0x376, 0x35A, 0x360, 0x36F, 0x368, 0x345, 0x1A1,
            0x1A4, 0x1A0, 0x1A3, 0x19F, 0x1A2, 0x1EE, 0x3E, 0x28E, 0xFB, 0x282,
            0x2A6, 0x2BE, 0xF1, 0x29A, 0x2CE, 0x260, 0x276, 0x20, 0x1F8, 0x1E,
            0x23F, 0xD3, 0x1F, 0xE7, 0x251, 0x2B2, 0xDD, 0x105, 0x24D, 0x2EE,
            0x2DE, 0x64, 0x1F2, 0x39, 0x28B, 0x320, 0xF6, 0x27F, 0x326, 0x2A3,
            0x2BB, 0xEC, 0x297, 0x25D, 0x273, 0x11, 0x1FC, 0x2D9, 0xF, 0x353,
            0x17D, 0xCE, 0x10, 0xCA, 0xC7, 0xC4, 0x22E, 0x30B, 0xE2, 0x49,
            0x212, 0x14B, 0x13B, 0x2AF, 0xD8, 0x100, 0x32E, 0x204, 0x319, 0x7C,
            0x220, 0x240, 0x14E, 0x2C6, 0x178, 0x29, 0x27, 0x28, 0x37A, 0x1C5,
            0x1C8, 0x1C4, 0x1C7, 0x1C3, 0x1C6, 0x365, 0x55, 0x189, 0x18C, 0x188,
            0x34, 0x2F1, 0x18B, 0x9F, 0x187, 0x47, 0x18A, 0x33, 0x77, 0x2E5,
            0x32B, 0x23D, 0x250, 0x241, 0x11F, 0x283, 0x14C, 0x13C, 0x11D,
            0x2E0, 0x140, 0x130, 0x2D4, 0x2E, 0x307, 0x14F, 0x165, 0x2DC, 0x277,
            0x246, 0x2C8, 0x288, 0x27C, 0x2A0, 0x2B8, 0x294, 0x25A, 0x270, 0x71,
            0x2C1, 0x2AC, 0x4F, 0x172, 0x384, 0x201, 0x109, 0x34B, 0x29B, 0x2B3,
            0x2F9, 0x2FE, 0x2F4, 0x15A, 0x2FC, 0x230, 0x214, 0x206, 0x222,
            0x2E3, 0x4C, 0x113, 0x170, 0x2E8, 0x28F, 0x182, 0x120, 0xBA, 0x2CD,
            0x269, 0x255, 0x26B, 0x15C, 0x1F7, 0x121, 0x2F8, 0x1F4, 0x286,
            0x27A, 0x29E, 0x2B6, 0x2FD, 0x292, 0x258, 0x26E, 0x1FE, 0x2F3,
            0x185, 0x2AA, 0x186, 0x2D8, 0x30, 0x59, 0x2F, 0x72, 0x2D3, 0x122,
            0x30E, 0xB9, 0x4D, 0x2C, 0x2A, 0x2B, 0x30A, 0x37F, 0x253, 0x30D,
            0x123, 0x12C, 0x17E, 0x5B, 0x180, 0x14A, 0x13A, 0xFD, 0xE9, 0x268,
            0x1EA, 0x10E, 0x359, 0x35F, 0x36E, 0x367, 0x346, 0x1A7, 0x1AA,
            0x1A6, 0x1A9, 0x1A5, 0x1A8, 0x2FB, 0x1F0, 0x40, 0x33C, 0xF3, 0x300,
            0x1E9, 0x1EC, 0x1E8, 0x26, 0x1FA, 0x380, 0x24, 0xD5, 0x25, 0x2F6,
            0x1EB, 0x232, 0x348, 0x216, 0xDF, 0x107, 0x208, 0x1E7, 0x224, 0x2E7,
            0x11C, 0x248, 0x265, 0x32A, 0x23E, 0x38, 0x28A, 0x31F, 0xF5, 0x27E,
            0x325, 0x2A2, 0x2BA, 0xEB, 0x296, 0x25C, 0x272, 0xE, 0xC, 0x352,
            0x154, 0xCD, 0xD, 0x22F, 0xE1, 0x60, 0x213, 0x2AE, 0xD7, 0xFF,
            0x32D, 0x205, 0x318, 0x344, 0x221, 0x2EF, 0x243, 0x30F, 0x2D, 0x379,
            0x364, 0x148, 0x118, 0x74, 0x152, 0x46, 0x15D, 0x6E, 0x145, 0x135,
            0x126, 0x84, 0x2A8, 0x2C7, 0x284, 0x278, 0x29C, 0x2B4, 0x290, 0x256,
            0x26C, 0x2C0, 0x138, 0x83, 0x173, 0x313, 0x143, 0x133, 0x10A, 0xBD,
            0xBC, 0x7E, 0x34A, 0x2EA, 0x387, 0x227, 0x229, 0x22B, 0x228, 0x233,
            0x24B, 0x226, 0x217, 0x22A, 0x2C4, 0x225, 0x57, 0x34D, 0x235, 0x219,
            0x20B, 0x237, 0x21B, 0x20D, 0x239, 0x21D, 0x236, 0x20F, 0x21A,
            0x20C, 0x234, 0x218, 0x20A, 0x238, 0x21C, 0x20E, 0x209, 0x144,
            0x134, 0x15E, 0x2FA, 0x175, 0x5D, 0x2F2, 0x114, 0x69, 0x2FF, 0x13E,
            0x6C, 0x6B, 0x150, 0x16A, 0x15F, 0x2F5, 0x12E, 0x2E4, 0x22C, 0x12A,
            0x128, 0x129, 0x12B, 0x45, 0x7A, 0x110, 0x10F, 0x112, 0x111, 0x2E2,
            0x247, 0x34F, 0xAC, 0x341, 0x115, 0x2E1, 0x119, 0x4B, 0x2DB, 0x2C3,
            0x2CB, 0x35D, 0x363, 0x372, 0x36B, 0x323, 0x329, 0x356, 0x331,
            0x31C, 0x16F, 0x151, 0x51, 0x62, 0x183, 0x161, 0x23C, 0x301, 0x162,
            0x2D5, 0x266, 0x164, 0x1F6, 0x3B, 0x28C, 0x136, 0x31E, 0xF8, 0x280,
            0x324, 0x2A4, 0x2BC, 0xEE, 0x298, 0x25E, 0x274, 0x17, 0x200, 0x15,
            0x351, 0x156, 0xD0, 0x16, 0xE4, 0x13D, 0x12D, 0x2B0, 0xDA, 0x102,
            0x32C, 0x317, 0x146, 0x358, 0x35E, 0x1D1, 0x1D4, 0x1D0, 0x1D3,
            0x1CF, 0x1D2, 0x36D, 0x366, 0x347, 0x1AD, 0x1B0, 0x1AC, 0x1AF,
            0x1AB, 0x1AE, 0x34E, 0x314, 0x76, 0x33F, 0x24C, 0x14D, 0x24A, 0x303,
            0x378, 0x1DD, 0x1E0, 0x1DC, 0x1DF, 0x1DB, 0x1DE, 0x373, 0x1CB,
            0x1CE, 0x1CA, 0x1CD, 0x1C9, 0x1CC, 0x73, 0xE5, 0x3C, 0xF9, 0xEF,
            0x1A, 0x18, 0x357, 0x157, 0xD1, 0x19, 0xDB, 0x103, 0x31D, 0x343,
            0x160, 0x312, 0x195, 0x198, 0x194, 0x197, 0x193, 0x196, 0x35B,
            0x361, 0x370, 0x369, 0x23B, 0x263, 0x63, 0x1F1, 0x37, 0x289, 0x321,
            0xF4, 0x27D, 0x327, 0x2A1, 0x2B9, 0xEA, 0x1E3, 0x295, 0x1E6, 0x1E2,
            0x25B, 0x271, 0xB, 0x1FB, 0x9, 0x354, 0x17C, 0x153, 0xCC, 0xA, 0xC9,
            0xC6, 0xC3, 0x1E5, 0x22D, 0x30C, 0xE0, 0x5F, 0x48, 0x211, 0x142,
            0x132, 0x2AD, 0xD6, 0xFE, 0x32F, 0x203, 0x24E, 0x1E1, 0x31A, 0x342,
            0x309, 0x1E4, 0x21F, 0x2ED, 0x242, 0x210, 0x385, 0x37D, 0x2CF,
            0x2D6, 0x82, 0x81, 0x386, 0x43, 0x305, 0x7F, 0x287, 0x27B, 0x29F,
            0x2B7, 0x293, 0x259, 0x26F, 0x2AB, 0x5A, 0x302, 0x171, 0x2BF, 0x2C2,
            0x159, 0x66, 0x68, 0x67, 0x1D7, 0x1DA, 0x1D6, 0x1D9, 0x1D5, 0x1D8,
            0x3F, 0xFC, 0xF2, 0x23, 0x21, 0xD4, 0x22, 0x231, 0xE8, 0x215, 0xDE,
            0x106, 0x207, 0x24F, 0x223, 0x2E6, 0x1ED, 0x381, 0x80, 0x2C9, 0x340,
            0x2EB, 0x75, 0x249, 0x2C5, 0xC0, 0xBE, 0xC2, 0xC1, 0xBF, 0x149,
            0x139, 0xBB, 0x2A7, 0x33B, 0x335, 0x334, 0x338, 0x333, 0x339, 0x336,
            0x33A, 0x337, 0x306, 0x349, 0x70, 0x2DA, 0x34C, 0x383, 0x11E, 0x36,
            0x54, 0x19B, 0x19E, 0x19A, 0x5, 0x3, 0x4, 0x32, 0x52, 0x19D, 0x11A,
            0x92, 0x199, 0x184, 0x19C, 0x31, 0x261, 0x202, 0x10B, 0x10C, 0x4E,
            0x2D0, 0x6A, 0x141, 0x131, 0x37E, 0x5C, 0x26A, 0x2DD, 0x245, 0x108,
            0x10D, 0x127, 0x254, 0x17A, 0x17B, 0x21E, 0x56, 0x176, 0x11B, 0x13F,
            0x12F, 0x2CC, 0x2EC, 0x2DF, 0x33E, 0x2CA, 0x7B, 0x177, 0x44, 0x79,
            0x310, 0x1F5, 0x285, 0x279, 0x29D, 0x2B5, 0x291, 0x257, 0x26D,
            0x1FF, 0x2A9, 0x58, 0x37B, 0x374, 0x36C, 0x147, 0x264, 0x65, 0x1EF,
            0x3D, 0x28D, 0xFA, 0x281, 0x2A5, 0x2BD, 0xF0, 0x299, 0x25F, 0x275,
            0x1D, 0x1F9, 0x1B, 0x158, 0xD2, 0x1C, 0xE6, 0x61, 0x4A, 0x252,
            0x137, 0x2B1, 0xDC, 0x104, 0x332, 0x308, 0x244, 0x304, 0x17F, 0x35,
            0x42, 0x53, 0x1B9, 0x1BC, 0x1B8, 0x2, 0x0, 0x350, 0x1, 0x1BB, 0x85,
            0x1B7, 0x7D, 0x1BA, 0x1F3, 0x1FD, 0x2E9, 0x3A, 0x322, 0xF7, 0x328,
            0xED, 0x14, 0x12, 0x355, 0x155, 0xCF, 0x13, 0xCB, 0xC5, 0xD9, 0x101,
            0x330, 0x31B, 0x2F0, 0x377, 0x35C, 0x362, 0xC8, 0x371, 0xE3, 0x36A,
            0x1B3, 0x1B6, 0x1B2, 0x1B5, 0x1B1, 0x1B4 };
        #endregion

        public ObjectEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            IsModified = false;
            Util.LoadObjectNameList();

            objectNameColumn.Items.Add("None");
            for (int i = 0; i < ObjectSortedList.Length; i++)
                objectNameColumn.Items.Add(ObjectNameList[ObjectSortedList[i]]);
            objectDataGridView.Rows.Add(999);
            objectDataGridView.CancelEdit();

            for (int i = 0; i < 999; i++)
            {
                int objectIndex = BitConverter.ToInt16(MainForm.SaveData, objectOffset + 4 * i);
                objectDataGridView.Rows[i].Cells[1].Value =
                    BitConverter.ToInt16(MainForm.SaveData, objectOffset + 4 * i + 2);
                if (objectIndex == -1)
                {
                    objectDataGridView.Rows[i].Cells[0].Value = "None";
                    objectDataGridView.Rows[i].Cells[1].ReadOnly = true;
                    objectDataGridView.Rows[i].Cells[1].Style = MainForm.GrayCellStyle;
                }
                else
                    objectDataGridView.Rows[i].Cells[0].Value = ObjectNameList[objectIndex];
            }
            DataLoaded = true;
        }

        private void objectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            ComboBox cb;
            try
            {
                cb = (ComboBox)objectDataGridView.EditingControl;
            }
            catch (InvalidCastException)
            {
                return;
            }
            if (cb != null) cb.DroppedDown = true;
        }

        private void objectDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (objectDataGridView.CurrentCell.ColumnIndex == 0 &&
                objectDataGridView.IsCurrentCellDirty)
                objectDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void objectDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            if (!IsModified) IsModified = true;
            if (e.ColumnIndex == 0)
            {
                if (objectDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "None")
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Value = 1;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Style =
                        objectDataGridView.DefaultCellStyle;
                }
                else
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Value = 0;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Style =
                        MainForm.GrayCellStyle;
                }
            }
        }

        private void objectDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (objectDataGridView.Rows[e.RowIndex].IsNewRow) return;
            if (objectDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly) return;
            if (e.ColumnIndex == 1)
            {
                int amount;
                bool isValidAmount = Int32.TryParse(e.FormattedValue.ToString(), out amount);
                if (!isValidAmount || amount < 1 || amount > 99)
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ErrorText =
                        "Amount must be a valid number between 1 and 99";
                    objectDataGridView.CancelEdit();
                }
                else
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ErrorText = null;
            }
        }

        public void SaveObjects()
        {
            if (!IsModified) return;
            Tuple<ushort, short>[] objectList = new Tuple<ushort, short>[999];
            for (int i = 0; i < 999; i++)
            {
                int objectIndex = Array.IndexOf(ObjectNameList, 
                    objectDataGridView.Rows[i].Cells[0].Value.ToString());
                short amount;
                bool isValidAmount = Int16.TryParse(objectDataGridView.Rows[i].Cells[1].Value.ToString(),
                    out amount);
                objectList[i] = Tuple.Create((ushort)(objectIndex & 0xFFFF), amount);
            }
            Array.Sort(objectList, (x, y) => x.Item1.CompareTo(y.Item1));
            int localOffset = objectOffset;
            for (int i = 0; i < 999; i++)
            {
                MainForm.SaveData[localOffset] = (byte)(objectList[i].Item1 & 0xFF);
                MainForm.SaveData[localOffset + 1] =
                    (byte)((objectList[i].Item1 >> 8) & 0xFF);
                MainForm.SaveData[localOffset + 2] =
                    (byte)(objectList[i].Item2 & 0xFF);
                MainForm.SaveData[localOffset + 3] =
                    (byte)((objectList[i].Item2 >> 8) & 0xFF);
                localOffset += 4;
            }
        }

        private void objectx99Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 999; i++)
            {
                if ((string)objectDataGridView.Rows[i].Cells[0].Value != "None")
                    objectDataGridView.Rows[i].Cells[1].Value = 99;
            }
        }

        private void ObjectEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveObjects();
        }
    }
}
