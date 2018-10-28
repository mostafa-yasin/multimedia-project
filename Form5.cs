using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string input = "";
        string prev_symbole_code = "";
        string prev_new_code = "";
        string new_pos = "left"; // default on left of tree
        int cc = 0;
        bool flag_new = true;
        int cv = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            list_symbole.Items.Clear();
            list_code.Items.Clear();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {
                txt_input.ReadOnly = true;
                txt_symbole.ReadOnly = true;
                txt_code.ReadOnly = true;
                btn_submit.Visible = false;
                input = txt_input.Text;
                string[] arr1 = { "0", "01", "001", "0001", "00001", "000001", "0000001" }; //char left side
                string[] arr2 = { "1", "11", "101", "1001", "10001", "100001", "1000001" }; //char right side

                string[] arr3 = { "0", "00", "000", "0000", "00000", "000000" };// new of left side
                string[] arr4 = { "0", "10", "100", "1000", "10000", "100000" }; //new of right side

                List<nodes> new_node = new List<nodes>();
                //nodes[] node_temp = new nodes[input.Length];
                nodes node_temp = new nodes();
                nodes node_swap = new nodes();
                char input_char;
                bool check_new_char = false;
                int index;
                int temp;
                int temp_index = 0;
                int temp_level;

                #region First_char
                //Fetch the First Character
                node_temp.str = input[0];//Convert.ToChar(input.Substring(1, 1))
                node_temp.count = 1;
                node_temp.pos = "right";
                node_temp.code = "1";
                node_temp.level = 0;

                // fetch code from initial table
                index = list_symbole.FindString(input[0].ToString());
                list_code.SelectedIndex = index;
                prev_symbole_code = list_code.SelectedItem.ToString();

                // Update Initial table for symbole
                list_code.Items[index] = node_temp.code;

                // fetch previous new code
                index = list_symbole.FindString("new");
                list_code.SelectedIndex = index;
                prev_new_code = list_code.SelectedItem.ToString();

                //output Code in output table
                list_symbole_result.Items.Add("new");
                list_code_result.Items.Add(prev_new_code);
                list_symbole_result.Items.Add(input[0].ToString());
                list_code_result.Items.Add(prev_symbole_code);

                // Update Initial table for new
                list_code.Items[index] = "0";

                //new_node.Add(node_temp);
                new_node.Add(new nodes() { str = node_temp.str, pos = node_temp.pos, code = node_temp.code, count = node_temp.count, level = node_temp.level });

                //End
                #endregion
                //MessageBox.Show(input[0].ToString());
                list_output.Items.Add(input[0] + " New");

                for (int i = 1; i < input.Length; i++)  // -1
                {

                    check_new_char = true;

                    // Take Character from input
                    input_char = Convert.ToChar(input.Substring(i, 1));
                    //rich_output_txt.Text += input_char;

                    // Check if it is new char or old
                    //foreach (nodes item in new_node)//.Where(x => x.str == input_char).Take(1).ToList()
                    for (int j = 0; j < new_node.Count; j++)
                    {
                        // is existing char
                        if (new_node[j].str == input_char)
                        {
                            list_output.Items.Add(input_char + " Exist");

                            new_node[j].count++;

                            // Output Symbole Code
                            // fetch code from initial table
                            index = list_symbole.FindString(input.Substring(i, 1));
                            list_code.SelectedIndex = index;
                            prev_symbole_code = list_code.SelectedItem.ToString();

                            list_symbole_result.Items.Add(input.Substring(i, 1));
                            list_code_result.Items.Add(prev_symbole_code);

                            #region try
                            //Check for Conditions (Update tree)
                            // all condition must detect
                            /*#region Update_Tree
                            // pos, level, count

                            if (new_node.Count>=2 && new_node[new_node.Count - 1].count > new_node[new_node.Count - 2].count)
                            {
                                temp_level = new_node[new_node.Count - 2].level;
                                int d = new_node.Count - 2;
                                // to obtain who object will swap with current "Far object"
                                for (int n = 0; n < new_node.Count -1; n++)
                                {
                                    if (new_node[new_node.Count - 1].count > new_node[n].count)
                                    {
                                        //MessageBox.Show("Here!!");
                                        temp_level = new_node[n].level;
                                        d = n;
                                        break;
                                    }
                                }

                                //rich_output_txt.Text += "ok";
                                node_swap.str = new_node[new_node.Count - 1].str;//c
                                node_swap.count = new_node[new_node.Count - 1].count;//2
                                new_node[new_node.Count - 1].str = new_node[d].str;//d
                                new_node[new_node.Count - 1].count = new_node[d].count;//1
                                new_node[d].str = node_swap.str;//c
                                new_node[d].count = node_swap.count;//2

                                MessageBox.Show(new_node[new_node.Count - 1].str.ToString() + " " + new_node[new_node.Count - 1].code + " " + new_node[new_node.Count - 1].count);//c
                                MessageBox.Show(new_node[d].str.ToString() + " " + new_node[d].code + " " + new_node[d].count);//d

                                // Condition of that if right tree not >= left tree
                                if (new_node[0].pos == "right")
                                {
                                    int count_sum = 0;
                                    for (int m = 1; m < new_node.Count; m++)
                                    {
                                        count_sum += new_node[m].count;
                                    }

                                    if (new_node[0].count < count_sum)
                                    {
                                        new_node[0].pos = "left";
                                        new_node[0].code = arr1[0];
                                        MessageBox.Show(new_node[0].str.ToString() + " " + new_node[0].code);
                                        for (int v = 1; v < new_node.Count; v++)
                                        {
                                            new_node[v].pos = "right";
                                            new_node[v].code = arr2[v];
                                            MessageBox.Show(new_node[v].str.ToString() + " " + new_node[v].code);
                                        }
                                    }
                                }

                            }


                            

                            // Update Initial table for symbole or all symbols

                            for (int h = 0; h < new_node.Count; h++)
                            {
                                // fetch code from initial table
                                index = list_symbole.FindString(new_node[h].str.ToString());
                                list_code.SelectedIndex = index;

                                // Update Initial table for symbole
                                list_code.Items[index] = new_node[h].code;
                            }
                            #endregion*/
                            #endregion

                            check_new_char = false;
                            break;

                        }
                    }

                    // Is new char
                    if (check_new_char == true)
                    {
                        list_output.Items.Add(input_char + " New");

                        node_temp.str = input_char;
                        node_temp.count = 1;
                        node_temp.pos = "left";//****

                        if (new_pos == "left")
                        {
                            nodes obj = new_node[new_node.Count - 1]; // last node
                            node_temp.level = obj.level + 1;  // insert new level for new char
                            temp = obj.level + 1;
                            node_temp.code = arr1[node_temp.level];

                            //new_node.Add(node_temp);
                            new_node.Add(new nodes() { str = node_temp.str, pos = node_temp.pos, code = node_temp.code, count = node_temp.count, level = node_temp.level });

                            //rich_output_txt.Text += new_node[new_node.Count - 1].str; // show save char

                            // fetch code from initial table
                            index = list_symbole.FindString(input.Substring(i, 1));
                            list_code.SelectedIndex = index;
                            prev_symbole_code = list_code.SelectedItem.ToString();

                            // fetch previous new code
                            index = list_symbole.FindString("new");
                            list_code.SelectedIndex = index;
                            prev_new_code = list_code.SelectedItem.ToString();

                            //output Code in output table
                            list_symbole_result.Items.Add("new");
                            list_code_result.Items.Add(prev_new_code);
                            list_symbole_result.Items.Add(input.Substring(i, 1));
                            list_code_result.Items.Add(prev_symbole_code);


                            //Check for Conditions (Update tree)
                            // only condition of checking the left and right tree counts



                            //break;
                        }
                        /*else // new on right 
                        {
                            nodes obj = new_node[new_node.Count - 1]; // last node
                            node_temp.level = obj.level + 1;  // insert new level for new char
                            temp = obj.level + 1;
                            node_temp.code = arr2[node_temp.level];

                            //new_node.Add(node_temp);
                            new_node.Add(new nodes() { str = node_temp.str, pos = node_temp.pos, code = node_temp.code, count = node_temp.count, level = node_temp.level });

                            // fetch code from initial table
                            index = list_symbole.FindString(input.Substring(i, 1));
                            list_code.SelectedIndex = index;
                            prev_symbole_code = list_code.SelectedItem.ToString();
                                
                            // fetch previous new code
                            index = list_symbole.FindString("new");
                            list_code.SelectedIndex = index;
                            prev_new_code = list_code.SelectedItem.ToString();

                            //output Code in output table
                            list_symbole_result.Items.Add("new");
                            list_code_result.Items.Add(prev_new_code);
                            list_symbole_result.Items.Add(input.Substring(i, 1));
                            list_code_result.Items.Add(prev_symbole_code);

                            //Check for Conditions (Update tree)


                            // Update Initial table for symbole
                            //list_code.Items[index] = node_temp.code;

                            // Update Initial table for new
                            //list_code.Items[index] = arr4[temp];

                            //break;
                        }*/

                    }


                    #region Update_Tree
                    // pos, level, count

                    if (new_node.Count >= 2 && new_node[new_node.Count - 1].count > new_node[new_node.Count - 2].count)
                    {
                        temp_level = new_node[new_node.Count - 2].level;
                        int d = new_node.Count - 2;
                        // to obtain who object will swap with current "Far object"
                        for (int n = 0; n < new_node.Count - 1; n++)
                        {
                            if (new_node[new_node.Count - 1].count > new_node[n].count)
                            {
                                //MessageBox.Show("Here!!");
                                temp_level = new_node[n].level;
                                d = n;
                                break;
                            }
                        }

                        //rich_output_txt.Text += "ok";
                        node_swap.str = new_node[new_node.Count - 1].str;//c
                        node_swap.count = new_node[new_node.Count - 1].count;//2
                        new_node[new_node.Count - 1].str = new_node[d].str;//d
                        new_node[new_node.Count - 1].count = new_node[d].count;//1
                        new_node[d].str = node_swap.str;//c
                        new_node[d].count = node_swap.count;//2

                        MessageBox.Show(new_node[new_node.Count - 1].str.ToString() + " " + new_node[new_node.Count - 1].code + " " + new_node[new_node.Count - 1].count);//c
                        MessageBox.Show(new_node[d].str.ToString() + " " + new_node[d].code + " " + new_node[d].count);//d

                        // Condition of that if right tree not >= left tree
                        if (new_node[0].pos == "right")
                        {
                            int count_sum = 0;
                            for (int m = 1; m < new_node.Count; m++)
                            {
                                count_sum += new_node[m].count;
                            }

                            if (new_node[0].count < count_sum)
                            {
                                new_node[0].pos = "left";
                                new_node[0].code = arr1[0];
                                MessageBox.Show(new_node[0].str.ToString() + " " + new_node[0].code);
                                for (int v = 1; v < new_node.Count; v++)
                                {
                                    new_node[v].pos = "right";
                                    new_node[v].code = arr2[v];
                                    MessageBox.Show(new_node[v].str.ToString() + " " + new_node[v].code);
                                }
                            }
                        }

                    }




                    // Update Initial table for symbole or all symbols

                    for (int h = 0; h < new_node.Count; h++)
                    {
                        // fetch code from initial table
                        index = list_symbole.FindString(new_node[h].str.ToString());
                        list_code.SelectedIndex = index;

                        // Update Initial table for symbole
                        list_code.Items[index] = new_node[h].code;
                    }
                    #endregion


                    int mm;

                    // Update Initial table for new
                    if (new_node[0].pos == "right")
                    {
                        mm = new_node[new_node.Count - 1].level;

                        list_code.Items[0] = arr3[mm];
                        prev_new_code = arr3[mm];
                        temp_index++;
                    }
                    else
                    {
                        mm = new_node[new_node.Count - 1].level;
                        list_code.Items[0] = arr4[mm];
                        prev_new_code = arr4[mm];
                        temp_index++;
                    }


                }//end for loop

                //rich_output_txt.Text = "";
                for (int i = 0; i < new_node.Count; i++)
                {
                    rich_output_txt.Text += new_node[i].str + "\t";
                }
            }// end if

            ///////////// for decoding /////////////////
            cv = list_code_result.Items.Count;

        }


        private void get_code()
        {
            string[] arr33 = { "0", "00", "000", "0000", "00000", "000000" };// new of left side
            string[] arr44 = { "0", "10", "100", "1000", "10000", "100000" }; //new of right side


            list_code_result.SelectedIndex = cc;
            input = list_code_result.SelectedItem.ToString(); // fetch code 
            // check if it is new or not
            for (int i = 0; i < arr33.Length; i++)
            {
                if (input == arr33[i])
                {
                    cc++;
                    list_code_result.SelectedIndex = cc;
                    input = list_code_result.SelectedItem.ToString(); // code
                    flag_new = true;
                    cv--;
                    break;
                }
            }

            for (int i = 0; i < arr44.Length; i++)
            {
                if (input == arr44[i])
                {
                    cc++;
                    list_code_result.SelectedIndex = cc;
                    input = list_code_result.SelectedItem.ToString();//code
                    flag_new = true;
                    cv--;
                    break;
                }
            }
            //cc++;
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            decode_txt.Text = "";
            get_code();
            string input_code;
            int tr;

            string[] arr1 = { "0", "01", "001", "0001", "00001", "000001", "0000001" }; //char left side
            string[] arr2 = { "1", "11", "101", "1001", "10001", "100001", "1000001" }; //char right side

            string[] arr3 = { "0", "00", "000", "0000", "00000", "000000" };// new of left side
            string[] arr4 = { "0", "10", "100", "1000", "10000", "100000" }; //new of right side

            List<nodes> new_node = new List<nodes>();
            nodes node_temp = new nodes();
            nodes node_swap = new nodes();
            char input_char;
            bool check_new_char = false;
            int index;
            int temp;
            int temp_index = 0;
            int temp_level;

            #region First_code
            //Fetch the First Character
            get_code();
            tr = listBox2.FindString(input);
            listBox1.SelectedIndex = tr;
            input_code = listBox1.SelectedItem.ToString();
            decode_txt.Text += input_code;

            node_temp.str = Convert.ToChar(input_code);
            node_temp.count = 1;
            node_temp.pos = "right";
            node_temp.code = "1";
            node_temp.level = 0;

            // fetch code from initial table
            index = listBox1.FindString(input_code);
            listBox2.SelectedIndex = index;
            prev_symbole_code = listBox2.SelectedItem.ToString();

            // Update Initial table for symbole
            listBox2.Items[index] = node_temp.code;

            // fetch previous new code
            index = listBox1.FindString("new");
            listBox2.SelectedIndex = index;
            prev_new_code = listBox2.SelectedItem.ToString();

            //output Code in output table
            /*list_symbole_result.Items.Add("new");
            list_code_result.Items.Add(prev_new_code);
            list_symbole_result.Items.Add(input[0].ToString());
            list_code_result.Items.Add(prev_symbole_code);*/

            // Update Initial table for new
            listBox2.Items[index] = "0";

            //new_node.Add(node_temp);
            new_node.Add(new nodes() { str = node_temp.str, pos = node_temp.pos, code = node_temp.code, count = node_temp.count, level = node_temp.level });

            //End
            #endregion


            cc++; // for new code select
            for (int i = 1; i < cv; i++)  // -1
            {

                check_new_char = true;

                // Take Character from input                
                get_code();
                tr = listBox2.FindString(input);
                listBox1.SelectedIndex = tr;
                input_code = listBox1.SelectedItem.ToString();
                decode_txt.Text += input_code.ToString();


                // Check if it is new char or old
                for (int j = 0; j < new_node.Count; j++)
                {
                    // is existing char
                    if (new_node[j].str == Convert.ToChar(input_code))
                    {

                        new_node[j].count++;

                        // Output Symbole Code
                        // fetch code from initial table
                        index = listBox1.FindString(input_code);
                        listBox2.SelectedIndex = index;
                        prev_symbole_code = listBox2.SelectedItem.ToString();

                        check_new_char = false;
                        break;

                    }
                }

                // Is new char
                if (check_new_char == true)
                {

                    node_temp.str = Convert.ToChar(input_code);
                    node_temp.count = 1;
                    node_temp.pos = "left";//****

                    if (new_pos == "left")
                    {
                        nodes obj = new_node[new_node.Count - 1]; // last node
                        node_temp.level = obj.level + 1;  // insert new level for new char
                        temp = obj.level + 1;
                        node_temp.code = arr1[node_temp.level];

                        //new_node.Add(node_temp);
                        new_node.Add(new nodes() { str = node_temp.str, pos = node_temp.pos, code = node_temp.code, count = node_temp.count, level = node_temp.level });

                        //rich_output_txt.Text += new_node[new_node.Count - 1].str; // show save char

                        // fetch code from initial table
                        index = listBox1.FindString(input_code);
                        listBox2.SelectedIndex = index;
                        prev_symbole_code = listBox2.SelectedItem.ToString();

                        // fetch previous new code
                        index = listBox1.FindString("new");
                        listBox2.SelectedIndex = index;
                        prev_new_code = listBox2.SelectedItem.ToString();

                        //output Code in output table
                        /*list_symbole_result.Items.Add("new");
                        list_code_result.Items.Add(prev_new_code);
                        list_symbole_result.Items.Add(input.Substring(i, 1));
                        list_code_result.Items.Add(prev_symbole_code);*/


                        //Check for Conditions (Update tree)
                        // only condition of checking the left and right tree counts



                        //break;
                    }

                }


                #region Update_Tree
                // pos, level, count

                if (new_node.Count >= 2 && new_node[new_node.Count - 1].count > new_node[new_node.Count - 2].count)
                {
                    temp_level = new_node[new_node.Count - 2].level;
                    int d = new_node.Count - 2;
                    // to obtain who object will swap with current "Far object"
                    for (int n = 0; n < new_node.Count - 1; n++)
                    {
                        if (new_node[new_node.Count - 1].count > new_node[n].count)
                        {
                            //MessageBox.Show("Here!!");
                            temp_level = new_node[n].level;
                            d = n;
                            break;
                        }
                    }

                    //rich_output_txt.Text += "ok";
                    node_swap.str = new_node[new_node.Count - 1].str;//c
                    node_swap.count = new_node[new_node.Count - 1].count;//2
                    new_node[new_node.Count - 1].str = new_node[d].str;//d
                    new_node[new_node.Count - 1].count = new_node[d].count;//1
                    new_node[d].str = node_swap.str;//c
                    new_node[d].count = node_swap.count;//2

                    MessageBox.Show(new_node[new_node.Count - 1].str.ToString() + " " + new_node[new_node.Count - 1].code + " " + new_node[new_node.Count - 1].count);//c
                    MessageBox.Show(new_node[d].str.ToString() + " " + new_node[d].code + " " + new_node[d].count);//d

                    // Condition of that if right tree not >= left tree
                    if (new_node[0].pos == "right")
                    {
                        int count_sum = 0;
                        for (int m = 1; m < new_node.Count; m++)
                        {
                            count_sum += new_node[m].count;
                        }

                        if (new_node[0].count < count_sum)
                        {
                            new_node[0].pos = "left";
                            new_node[0].code = arr1[0];
                            MessageBox.Show(new_node[0].str.ToString() + " " + new_node[0].code);
                            for (int v = 1; v < new_node.Count; v++)
                            {
                                new_node[v].pos = "right";
                                new_node[v].code = arr2[v];
                                MessageBox.Show(new_node[v].str.ToString() + " " + new_node[v].code);
                            }
                        }
                    }

                }




                // Update Initial table for symbole or all symbols

                for (int h = 0; h < new_node.Count; h++)
                {
                    // fetch code from initial table
                    index = listBox1.FindString(new_node[h].str.ToString());
                    listBox2.SelectedIndex = index;

                    // Update Initial table for symbole
                    listBox2.Items[index] = new_node[h].code;
                }
                #endregion


                int mm;

                // Update Initial table for new
                if (new_node[0].pos == "right")
                {
                    mm = new_node[new_node.Count - 1].level;

                    listBox2.Items[0] = arr3[mm];
                    prev_new_code = arr3[mm];
                    temp_index++;
                }
                else
                {
                    mm = new_node[new_node.Count - 1].level;
                    listBox2.Items[0] = arr4[mm];
                    prev_new_code = arr4[mm];
                    temp_index++;
                }

                cc++;
            }
        }



            class nodes
        {
            public char str;
            public string pos;  // postition of on left tree or right tree
            public string code;
            public int count;
            public int level;
            /*
            nodes(char s, string p, string cd, int cnt, int l)
            {
                str = s;
                pos = p;
                code = cd;
                count = cnt;
                level = l;
            }
            */
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_symbole.Text != "" && txt_code.Text != "")
            {
                list_symbole.Items.Add(txt_symbole.Text);
                list_code.Items.Add(txt_code.Text);

                txt_symbole.Clear();
                txt_code.Clear();
            }
        }





    }
}
