/* Brad Wells
 * 1/24/19
 * CIS 229.2258
 * Asg A
 * This program simulates a control panel for a submarine fleet. You are able to add,edit, and delete submarines
 *   as well as control their power, speed, depth, direction, and weapons
 */
//***************************************************************************************************************


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


namespace Asg1SubFleetCommander
{
    

    public partial class SubCommander : Form
    {
        public bool hasPower = false;
        

        // timer for power up visual
        private void Delay(int time, Action a)
        {
            System.Windows.Forms.Timer delay = new System.Windows.Forms.Timer();
            delay.Interval = 2000;
            
            delay.Tick += (s, e) => { a(); delay.Stop(); };delay.Start();

        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            
            throw new NotImplementedException();
        }

        //***************************************************************************************************************

        public SubCommander()
        {
            InitializeComponent();
            //pre load a submarine on startup
            Submarine preloadSub1 = new Submarine("SSN", "714");
            SubListBox.Items.Add(preloadSub1);
        }


        // when a submarine is clicked on, split its toString into display labels 
        private void SubListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SubListBox.SelectedIndex == -1)
            {
                //FeaturePanel.Enabled = false;
                return;
            }
                String input = SubListBox.SelectedItem.ToString();

                if (input != "")
                {
                    String[] split = input.Split('-');
                    SubNameTextBox.Text = split[0];
                    HullNumTextBox.Text = split[1];
                    PowerDisplayLabel.Text = split[2];
                    SpeedDisplay.Text = split[3];
                    DepthDisplay.Text = split[4];
                    UpdateButton.Visible = true;
                }

            //Submarine sub = (Submarine)SubListBox.SelectedItem;
            //update labels such as direction and speed here
            //String input = SubListBox.SelectedItem.ToString();
            //input.
            //SubNameTextBox.Text = sub.Name;
            //HullNumTextBox.Text = sub.HullNum;
            //PowerDisplayLabel.Text = sub.Power.ToString();
            //sub.ChangeDirection(CourseDisplay.Text);
            //StatusRTextBox.Text += String.Format("{0}", sub.DisplayAll());
            //FeaturePanel.Enabled = true;
                    } // end subListBox_selectedItemChanged

        //***************************************************************************************************************


        // this method adds a submarine to the list box
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            String newName;
            String newHullNum;
            bool power = false;
            try
            {
                newName = SubNameTextBox.Text;
                newHullNum = HullNumTextBox.Text;
                //if (PowerDisplayLabel.Text.Equals("ON"))
                //{
                //    power = true;
                //}
                //else
                //{
                //    power = false;
                //}
                
                Submarine newSub = new Submarine(newName, newHullNum,power);
                

                SubListBox.Items.Add(newSub);

            }
            catch(Exception ns)
            {
                MessageBox.Show(ns.Message + "\nPlease check your data and try again.");
            }

        } // end add


        // this method shows instructions to edit a submarine
        private void EditSub_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Select the submarine you wish to modify. Enter the new name\n" +
                "or hull number and click update.");
            
        } // end edit


        // this button updates a submarine name or hull
        private void button1_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {

                try
                {
                    String editName = (SubNameTextBox.Text);
                    String editHull = HullNumTextBox.Text;
                    int speed = Convert.ToInt32(SpeedDisplay.Text);
                    int depth = Convert.ToInt32(DepthDisplay.Text);
                    bool power;
                    if (PowerDisplayLabel.Text.Equals("ON"))
                    {
                        power = true;
                    }
                    else
                    {
                        power = false;
                    }

                    Submarine newEditSub = new Submarine(editName, editHull,power, speed, depth);


                    SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);
                    SubListBox.Items.Add(newEditSub.ToString());
                    MessageBox.Show("Submarine updated!");
                    UpdateButton.Visible = false;
                }
                catch(Exception update)
                {
                    MessageBox.Show(update.Message);
                }
            }
        } // end update

        // this button deletes a submarine from the list
        private void DeleteSub_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex != -1)
            {
                UpdateButton.Visible = false;
                SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);
            }
        } // end delete


        // this method powers on the submarine
        private void PowerUpButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (SubListBox.SelectedIndex != -1)
                {
                    String name = SubNameTextBox.Text;
                    String hull = HullNumTextBox.Text;
                    Submarine powerup = new Submarine(name, hull);
                    powerup.Power = true;
                    hasPower = true;
                   

                    StatusRTextBox.Text += (powerup.ToString() + " is Powering up...");
                    PowerUp(powerup);
                    PowerDisplayLabel.Text = "ON";
                    SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                    SubListBox.Items.Add(powerup);
                    SubListBox.SelectedItem = (powerup);

                }
                else
                {
                    throw new Exception("You must select the submarine to power up.");
                }
            }
            catch(Exception power)
            {
                MessageBox.Show(power.Message);
            }
            
        } // end powerup


        //***************************************************************************************************************

        // this method is called from the PowerUp function for the timer for the powerup visual display
        private void Action(Submarine powerup)
        {

            StatusRTextBox.BackColor = Color.FromArgb(64, 64, 64);
            StatusRTextBox.Text += String.Format("\n ...{0} is now Powered up.\n", powerup.ToString());
            //StatusRTextBox.Text += String.Format("{0}", powerup.DisplayAll());

        } // end Action


        public void PowerUp(Submarine powerup)
        {
            StatusRTextBox.BackColor = Color.Red;
            Delay(2000, () => Action(powerup)

        );
            powerup.Power = true;


        } // end PowerUp

        //***************************************************************************************************************

        // working on a method to create a new instance of a class
            //*update learing helper form in next project********************************
        private Object NewInstanceOfSub()
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return false;
            }
            else
            {

                try
                {
                    String newName = (SubNameTextBox.Text);
                    String newHull = HullNumTextBox.Text;

                    Submarine newSub = new Submarine(newName, newHull);


                    MessageBox.Show("new instance created");

                    return newSub;
                }
                catch (Exception newInstance)
                {
                    MessageBox.Show(newInstance.Message);
                }
            }
            return false;

        } // end newInstance

        //***************************************************************************************************************

        // these buttons provide direction to the submarine
        private void NButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull,power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "N";
                            CourseDisplay.Text = "N";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");
                    
                }
            }
        }



        private void NEButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "NE";
                            CourseDisplay.Text = "NE";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }

        }

        private void NWButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "NW";
                            CourseDisplay.Text = "NW";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "E";
                            CourseDisplay.Text = "E";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void WButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "W";
                            CourseDisplay.Text = "W";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void SButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "S";
                            CourseDisplay.Text = "S";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void SEButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "SE";
                            CourseDisplay.Text = "SE";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void SWButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power);


                        //MessageBox.Show("new instance created");
                        try
                        {

                            newSub.Direction = "SW";
                            CourseDisplay.Text = "SW";

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Direction: {1}...\n", newSub.ToString(), newSub.Direction);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);


                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        //***************************************************************************************************************

        //these methods change the speed of the submarine
        private void SpeedUpButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {
                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull,power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.Speed = Convert.ToInt32(SpeedDisplay.Text);
                            newSub.Speed += 5;
                            SpeedDisplay.Text = newSub.Speed.ToString();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new speed: {1}...\n", newSub.ToString(), newSub.Speed);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");
                }
            }
        }

        private void SpeedDownButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {

                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull,power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.Speed = Convert.ToInt32(SpeedDisplay.Text);
                            newSub.Speed -= 5;
                            SpeedDisplay.Text = newSub.Speed.ToString();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new speed: {1}...\n", newSub.ToString(), newSub.Speed);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        //***************************************************************************************************************

        //these methods fire the submarines weapons
        private void FireTorpedoButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {

                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull,power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.FireTorpedo();
                            StatusRTextBox.Text += newSub.FireTorpedo();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} Fired a Torpedo...\n", newSub.ToString());
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");
                }
            }
        }

        private void FireMissileButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {

                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull,power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.FireMissile();
                            StatusRTextBox.Text += newSub.FireMissile();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} fired a Missile...\n", newSub.ToString());
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        //***************************************************************************************************************

        // this method powers down the submarine
        private void PowerDownButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (SubListBox.SelectedIndex != -1)
                {
                    String name = SubNameTextBox.Text;
                    String hull = HullNumTextBox.Text;
                    Submarine powerDown = new Submarine(name, hull);
                    powerDown.Power = false;
                    hasPower = false;

                    StatusRTextBox.Text += (powerDown.ToString() + " is now Powered down...");
                    //PowerUp(powerDown);
                    SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                    SubListBox.Items.Add(powerDown);
                    SubListBox.SelectedItem = (powerDown);

                }
                else
                {
                    throw new Exception("You must select the submarine to power down.");
                }
            }
            catch (Exception power)
            {
                MessageBox.Show(power.Message);
            }
        } // end powerDown

        //***************************************************************************************************************

        //these methods control the depth of the submarine
        private void DepthUp_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {

                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.Depth = Convert.ToInt32(DepthDisplay.Text);
                            newSub.Depth += 50;
                            DepthDisplay.Text = newSub.Depth.ToString();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Depth: {1}...\n", newSub.ToString(), newSub.Depth);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        private void DepthDown_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                if (PowerDisplayLabel.Text.Equals("ON"))
                {

                    try
                    {
                        String newName = (SubNameTextBox.Text);
                        String newHull = HullNumTextBox.Text;
                        int speed = Convert.ToInt32(SpeedDisplay.Text);
                        int depth = Convert.ToInt32(DepthDisplay.Text);
                        bool power;
                        if (PowerDisplayLabel.Text.Equals("ON"))
                        {
                            power = true;
                        }
                        else
                        {
                            power = false;
                        }

                        Submarine newSub = new Submarine(newName, newHull, power,speed,depth);


                        //MessageBox.Show("new instance created");
                        try
                        {
                            newSub.Depth = Convert.ToInt32(DepthDisplay.Text);
                            newSub.Depth -= 50;
                            DepthDisplay.Text = newSub.Depth.ToString();

                        }
                        catch (Exception dir)
                        {
                            MessageBox.Show(dir.Message);
                        }

                        //MessageBox.Show(newSub.DisplayAll());
                        StatusRTextBox.Text += String.Format("{0} new Depth: {1}...\n", newSub.ToString(), newSub.Depth);
                        SubListBox.Items.RemoveAt(SubListBox.SelectedIndex);                 ///need to update the sub in the list box, then read the updated info back into the form for every change!!!!!!!!
                        SubListBox.Items.Add(newSub);
                        SubListBox.SelectedItem = (newSub);

                    }
                    catch (Exception newInstance)
                    {
                        MessageBox.Show(newInstance.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You must power on the Submarine first!");

                }
            }
        }

        //***************************************************************************************************************

        // this method allows the cursor to stay at the bottom of the status text box 
        private void StatusRTextBox_TextChanged(object sender, EventArgs e)
        {
            StatusRTextBox.SelectionStart = StatusRTextBox.Text.Length;
            StatusRTextBox.ScrollToCaret();
        }
    } // end SubCommander:Form

    //********************************************************************************************

    public class Submarine
    {
        public Submarine(String name, String hullNum)
        {
            this.Name = name;
            this.HullNum = hullNum;
            this.Power= power;
            this.Direction = direction;
            this.Speed = speed;
            this.Depth = depth;
            
        }
        public Submarine(String name, String hullNum, bool power)
        {
            this.Name = name;
            this.HullNum = hullNum;
            this.Power = power;
            this.Direction = direction;
            this.Speed = speed;
            this.Depth = depth;
        }

        public Submarine(String name, String hullNum, bool power,int speed, int depth )
        {
            this.Name = name;
            this.HullNum = hullNum;
            this.Power = power;
            this.Direction = direction;
            this.Speed = speed;
            this.Depth = depth;
        }

        //***************************************************************************************************************
        public String direc;
        private String name;
        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Equals(""))
                {
                    throw new Exception("You must enter the submarine name");
                }
                else
                {
                    name = value;
                }
                

            }
        }

        private String hullNum;
        public String HullNum
        {
            get
            {
                return hullNum;
            }
            set
            {

                if (value.Equals(""))
                {
                    throw new Exception("You must enter a hull number");
                }
                else if (value.Length < 3)
                {
                    throw new Exception("The hull number needs to be 3 digits long");
                }
                else if (value.Any(c=> char.IsLetter(c)))
                {
                    throw new Exception("The hull number needs to be numeric");
                }
                else
                {
                    hullNum = value;
                    
                }

            }
        }

        private bool power;
        public bool Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        private String direction;
        public String Direction
        {
            get
            {
                return direction;
            }
            set
            {

                    direction = value;
                

            }
        }
        public String d;

        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed can not be below 0!");
                }
                else
                {
                    speed = value;
                }
            }
        
        }

        private int depth;
        public int Depth
        {
            get
            {
                return depth;
            }
            set
            {
                if ( value < 0)
                {
                    throw new Exception("Submarine can not come above the water!");
                }
                else
                {
                    depth = value;

                }
                depth = value;
            }
        }


        //***************************************************************************************************************

        public override string ToString()
        {
            String display;
            String powerStatus;
            
            if (power == true)
            {
                powerStatus = "ON";
            }
            else
            {
                powerStatus = "OFF";
            }
            display = String.Format("{0}" + "-" + "{1}" + "-" + "{2}" + "-" + "{3}" + "-" + "{4}", Name, HullNum, powerStatus, speed.ToString(), depth.ToString());
            return display;
        }

        public String DisplayAll()
        {
            String powerStatus;

            if (power == true)
            {
                powerStatus = "ON";
            }
            else
            {
                powerStatus = "OFF";
            }

            String allInfo = String.Format("{0}"+ "-" + "{1}-- Power Status: {2}  Direction: {3}", Name, HullNum, powerStatus,Direction);
            return allInfo;
        }

        public String NameandNum()
        {
            String nameAndNum = String.Format("{0}" + "-" + "{1}", Name, HullNum);
            return nameAndNum;
        }

        //***************************************************************************************************************

        public string ChangeDirection(String dir)
        {
            if (dir.Equals("NE"))
            {
                d = "NE";
                return "NE";
              
                
            }
            return "Enter direction";
        }

        public string FireTorpedo()
        {
            String fire = "TORPEDO DEPLOYED! \n";
            return fire;
            
        }

        public string FireMissile()
        {
            String fire = "MISSILE DEPLOYED! \n";
            return fire;
        }
    } // end class Submarine
}
