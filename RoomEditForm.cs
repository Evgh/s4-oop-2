using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4_oop_2
{
    public partial class RoomEditForm : Form, IBindingForm
    {
        IBindingList secondary;
        public IBindingList PrimarySource => null;
        public IBindingList SecondarySource => secondary;

        //MainForm _parent;
        IFlat theFlat; 

        public RoomEditForm(IFlat flat)
        {
            InitializeComponent();

            theFlat = flat;
            listBoxRoomOrientation.DataSource = System.Enum.GetValues(typeof(Room.RoomOrientation));
            InitializeTrackBarArea();
            labelWindows.Text = trackBarWindows.Value.ToString();
        }
        public Form ToForm()
        {
            return this;
        }

        public void InitializePrimarySource(IBindingList source)
        {
            // не реализовано
        }

        public void InitializeSecondarySource(IBindingList source)
        {
            secondary = source;
            listBoxRooms.DataSource = SecondarySource;
        }

        internal void InitializeTrackBarArea()
        {
            int diff = 0;           
            if (theFlat.Rooms != null && theFlat.Rooms.Count > 0)
            {
                foreach (var room in theFlat.Rooms)
                {
                    diff += room.Area;
                }
            }
            trackBarArea.Maximum = theFlat.Area - diff;
        }
        private void trackBarArea_Scroll(object sender, EventArgs e)
        {
            labelArea.Text = trackBarArea.Value.ToString();
        }

        private void trackBarWindows_Scroll(object sender, EventArgs e)
        {
            labelWindows.Text = trackBarWindows.Value.ToString();
        }

        private void listBoxRoomOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddButton_Click(object sender, EventArgs e)
        {
            if (trackBarArea.Maximum > 0)
            {
                SecondarySource.Add(new Room(this.trackBarArea.Value, this.trackBarWindows.Value, (Room.RoomOrientation)this.listBoxRoomOrientation.SelectedItem));

                InitializeTrackBarArea();                    
                trackBarWindows.Value = 0;
                labelWindows.Text = trackBarWindows.Value.ToString();
                labelArea.Text = trackBarArea.Value.ToString();
            }
            else
            {
                MessageBox.Show("Невозможно создать еще одну комнату в квартире с заданной площадью");
            }
        }
    }
}
