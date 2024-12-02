using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_List_Vieow_ParProgracesApp
{
    public partial class Form1 : Form
    {
        bool dragging = false;
        private Point dragCursotpoint;
        private Point dragFormPoint;



        bool IsEmpty(string stValue)
        {
            return string.IsNullOrEmpty(stValue); 
        }
        void ShowErroProvider( Control control, string Message)
        {

            errorProvider1.SetError(control, Message);
        }
        bool CheckedInputInfo(string ID , string FristName , string LastName )
        {
            if(IsEmpty(ID) )
            {
                ShowErroProvider(txtbxID, "ID Should Have a Value ! ");
                return false;
            }
            else
            {
                ShowErroProvider(txtbxID, ""); 
            }
            if(IsEmpty(FristName))
            {
                ShowErroProvider(txtbxName, "Name Should Have a Value ! ");
                return false;
            }
            else
            {
                ShowErroProvider(txtbxName, "");
            }
            if (IsEmpty(LastName))
            {
                ShowErroProvider(txtbxLastName, "Last Name Should Have a Value ! ");
                return false;
            }
            else
            {
                ShowErroProvider(txtbxLastName, "");
            }
              return true;
        }
        void AddNewItemToListView(string ID, string FristName, string LastName)
        {
            ListViewItem Item = new ListViewItem(ID);
            Item.SubItems.Add(FristName);
            Item.SubItems.Add(LastName);
            listView1.Items.Add(Item);
        }
        void ProgressLodingVaule(byte LoadingValue)
        {
            progressBar1.Value = LoadingValue;
            lblloding.Text = "Loading.." + (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString() + "%";
            progressBar1.Refresh();
            lblloding.Refresh();
            
        }
        bool IgonrPrograssTools(bool visible = false)
        {
            IgnoreControlFromScreen(lblloding, visible);
            IgnoreControlFromScreen(progressBar1, visible);
            return visible;
        }
        bool LoadingCompiltedSuccessfully()
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                IgonrPrograssTools(true);
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                return true;
            }
            
            return false;
        }
        void FillListViewWith100Items()
        {
            
            
            for (byte i = 1; i <= 100.000; i ++ )
            {
              Thread.Sleep(100);
              AddNewItemToListView(i.ToString(), "Person FristName", "Person LastName");
              ProgressLodingVaule(i);
              listView1.Refresh();

            }


            
        }
        void ShowViewListMode(TreeNode Node)
        {
            if (Node.Text == " Tile")
            {
                listView1.View = View.Tile;
            }
            if (Node.Text == " Small Icon")
            {
                listView1.View = View.SmallIcon;
            }
            if (Node.Text == " Large Icon")
            {
                listView1.View = View.LargeIcon;
            }
            if (Node.Text == " List")
            {
                listView1.View = View.List;
            }
            if (!Node.Checked)
            {
                listView1.View = View.Details;
            }
        }
        void ClearTextBox()
        {
            txtbxID.Clear(); txtbxName.Clear(); txtbxLastName.Clear();
        }
        bool ResmoveItemFromListView()
        {
            if(listView1.Items.Count > 0 )
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                return true;
            }
            return false;
        }
        bool ResetListView(bool Resetlist = false)
        {
            if(Resetlist == true && listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
                return true;
            }
            else 
            return false;
        }
        void IgnoreControlFromScreen(Control control , bool Ignor = false)
        {
            control.Visible = !Ignor;
        }


        public Form1()
        {
            InitializeComponent();
            
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursotpoint = Cursor.Position;
                dragFormPoint = this.Location; 
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging == true )
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursotpoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif)); 
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            if(CheckedInputInfo(txtbxID.Text, txtbxName.Text, txtbxLastName.Text))
            {
                AddNewItemToListView(txtbxID.Text, txtbxName.Text, txtbxLastName.Text);
                ClearTextBox();
            }
            else
            {
                return; 
            }
                
        }

        private void btn_ExiteFromApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                 
                ShowErroProvider(txtbxID, "ID Should Have a Number Value !");
                txtbxID.Focus(); 
            }
            else
            {
                ShowErroProvider(txtbxID , "");
            }
        }

        private void txtbx_Validating(object sender, CancelEventArgs e)
        {
            if(IsEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                txtbxID.Focus();
                ShowErroProvider(((TextBox)sender), "This Text Should Have a Value !");
            }
            else
            {
                e.Cancel = false;
                ShowErroProvider(((TextBox)sender), "");
            }
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
         
            IgonrPrograssTools(false);
            FillListViewWith100Items();
            if(LoadingCompiltedSuccessfully())
            {
                btnFillList.Enabled = false;
                IgnoreControlFromScreen(bntResetListView, false);
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
                ShowViewListMode(e.Node);
        }

        private void bntRemovefromList_Click(object sender, EventArgs e)
        {
            ResmoveItemFromListView();
        }

        private void bntResetListView_Click(object sender, EventArgs e)
        {
           
            if (!ResetListView(true))
            {
                ShowErroProvider(bntResetListView, "To Reset !! List View Should Not Be Empty ");
                
            }
            else
            {
                IgnoreControlFromScreen(bntResetListView, true);
                btnFillList.Enabled = true;
            }
            
        }
    }
}
