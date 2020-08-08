using GiriftStudio_ETS2_Money_Hack.CheatEngine;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Utilities;

namespace GiriftStudio_ETS2_Money_Hack
{
    public partial class Form1 : Form
    {
        private Process[] processes;
        private IntPtr BaseAdress;
        private Process myProcess;
        private Memory memory;

        private IntPtr moneyIntPtr;
        private IntPtr speedIntPtr;

        globalKeyboardHook gkh = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();

            //gkh.HookedKeys.Add(Keys.F7);
            //gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }


        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            memory.WriteFloat(speedIntPtr, 500);
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyGroupBox.Enabled = false;
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {
            processes = Process.GetProcessesByName("eurotrucks2");
            if (processes.Length > 0)
            {
                BaseAdress = IntPtr.Zero;
                myProcess = processes[0];

                foreach (ProcessModule module in myProcess.Modules)
                {
                    if (module.ModuleName.Contains("eurotrucks2"))
                    {
                        BaseAdress = module.BaseAddress;
                        memory = new VAMemory("eurotrucks2");
                        label2.Text = "Program running";
                        RunProgram.Enabled = false;
                        moneyGroupBox.Enabled = true;
                        PreperaIntPtr();
                    }
                }

                CurrentMoneyText.Text = getMoneyCount().ToString();
            }
            else
            {
                MessageBox.Show("The game is not currently open.");
            }
        }

        private void PreperaIntPtr()
        {
            int moneyBaseAdress = memory.ReadInt32(BaseAdress + 0x010A2420);
            int byte1 = memory.ReadInt32((IntPtr) moneyBaseAdress + 0xC);
            moneyIntPtr = (IntPtr) byte1 + 0x10;

            int speedBaseAdress = memory.ReadInt32(BaseAdress + 0x010A231C);
            int speedInt = memory.ReadInt32((IntPtr) speedBaseAdress + 0x7B8);
            speedIntPtr = (IntPtr) speedInt + 0x728;
        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            int currentMoney = getMoneyCount();

            int addMoney = Int32.Parse(moneyAddCount.Text);


            memory.WriteInt32(moneyIntPtr, currentMoney + addMoney);

            if (currentMoney + addMoney == getMoneyCount())
            {
                moneyAddCount.Text = "";
                CurrentMoneyText.Text = getMoneyCount().ToString();
            }
            else
            {
                MessageBox.Show("There was a problem adding money");
            }
        }


        private int getMoneyCount()
        {
            if (BaseAdress != IntPtr.Zero)
            {
                int finalBaseAdress = memory.ReadInt32(moneyIntPtr);
                //int byte1 = memory.ReadInt32((IntPtr) finalBaseAdress + 0xC);
                //int money = memory.ReadInt32((IntPtr) byte1 + 0x10);
                return finalBaseAdress;
            }

            return -1;
        }
    }
}