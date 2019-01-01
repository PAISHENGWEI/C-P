using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildHouse
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            comboBox1.Items.Clear();
            for(int i=0;i<currentLocation.Exits.Length;i++)
            {
                comboBox1.Items.Add(currentLocation.Exits[i].Name);
            }
            comboBox1.SelectedIndex = 0;

            textBox1.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                button2.Visible = true;
            else
                button2.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasdoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasdoor.DoorLocation);
        }
    }
}
