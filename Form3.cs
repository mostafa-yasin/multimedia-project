using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<nodes> nodes_list = new List<nodes>();

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        private void btn_encode_Click(object sender, EventArgs e)
        {


            string sentence = txt_encode.Text;
            string sentence_distinct = new String(sentence.Distinct().ToArray());

            int nodes_num = sentence_distinct.Length - 1;
            int last_num_of_char = 0;

            //convert sentence into nodes
            for (int i = 0; i < sentence_distinct.Length; i++)
            {
                nodes node = new nodes();
                node.periroity = 0;
                node.str = sentence_distinct.Substring(i, 1);
                node.left = null;
                node.right = null;
                int cc = sentence.Count(f => f == Convert.ToChar(sentence_distinct.Substring(i, 1)));
                node.count = cc;
                node.check = 0;
                node.num_of_char = i + 1;
                last_num_of_char = i + 1;
                nodes_list.Add(node);
            }

            //sort list
            nodes_list = nodes_list.OrderBy(x => x.count).ToList();

            //create new nodes
            #region create new nodes
            for (int i = 0; i < sentence_distinct.Length - 1; i++)
            {
                //select first 2 elements that not checked
                List<nodes> new_node = new List<nodes>();
                //new_node = nodes_list.Where(x=> x.check==0).Take(2).ToList();
                nodes node1 = new nodes();
                nodes node2 = new nodes();
                nodes new_node_genrated = new nodes();


                foreach (var item in nodes_list.Where(x => x.check == 0).Take(1).ToList())
                {
                    node1.str = item.str;
                    node1.left = item.left;
                    node1.right = item.right;
                    node1.count = item.count;
                    node1.periroity = item.periroity;
                    node1.check = 1;
                    item.check = 1;
                    node1.num_of_char = item.num_of_char;
                }

                foreach (var item in nodes_list.Where(x => x.check == 0).Take(1).ToList())
                {
                    node2.str = item.str;
                    node2.left = item.left;
                    node2.right = item.right;
                    node2.count = item.count;
                    node2.periroity = item.periroity;
                    node2.check = 1;
                    item.check = 1;
                    node2.num_of_char = item.num_of_char;
                }

                if (node1.num_of_char < node2.num_of_char)
                {
                    MessageBox.Show(node1.num_of_char.ToString() + "<" + node2.num_of_char.ToString() + " case1");
                    new_node_genrated = nodes.create_new_node(node1, node2, i + 1, node2.num_of_char);
                }
                else
                {
                    MessageBox.Show(node1.num_of_char.ToString() + ">" + node2.num_of_char.ToString() + " case2");
                    new_node_genrated = nodes.create_new_node(node2, node1, i + 1, node1.num_of_char);
                }
                nodes_list.Add(new_node_genrated);

                //sort array
                nodes_list = nodes_list.OrderBy(x => x.count).ToList();



                screen_text.Text += "##############################New Level#############################" + "\n";

                foreach (var item in nodes_list)
                {
                    screen_text.Text += (item.str + " LEFT: " + item.left + " RIGHT: " + item.right + " COUNT: " + item.count + " PERIORITY: " + item.periroity + " CHECK: " + item.check + " Num OF CHAR: " + item.num_of_char + "\n");
                    screen_text.Text += ("__________________________________________________________________" + "\n");
                }


            }
            #endregion

            //extract the code

            List<nodes> primary_nodes = new List<nodes>();
            primary_nodes = nodes_list.Where(x => x.periroity == 0).ToList();

            for (int i = 0; i < sentence_distinct.Length; i++)
            {
                string code = "";
                string str = primary_nodes.First().str;
                //string str="a";
                List<nodes> searched_for_str = nodes_list.Where(x => x.str.Contains(str)).ToList();
                searched_for_str.OrderBy(x => x.periroity);

                foreach (var item in searched_for_str)
                {
                    if (str == item.left)
                    {
                        code += "0";
                        str = item.str;
                    }
                    if (str == item.right)
                    {
                        code += "1";
                        str = item.str;
                    }
                }

                screen_text.Text += ("Code of " + primary_nodes.First().str + " is= " + Reverse(code) + "\n");
                primary_nodes.RemoveAt(0);
            }

        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
             List<nodes> sorted_list_periroity = new List<nodes>();
            //List<nodes> first_item = new List<nodes>();
            List<nodes> next_item = new List<nodes>();
            //List<nodes> final_item = new List<nodes>();



            sorted_list_periroity = nodes_list.OrderByDescending(x => x.periroity).ToList();
            next_item = sorted_list_periroity.Take(1).ToList();

            foreach (var item in sorted_list_periroity)
            {
                screen2.Text += (item.str + " LEFT: " + item.left + " RIGHT: " + item.right + " COUNT: " + item.count + " PERIORITY: " + item.periroity + " CHECK: " + item.check + "\n");
                screen2.Text += ("__________________________________________________________________" + "\n");
            }


            string code_input_sentence = txt_decode.Text;
            int periroity_for_loop=1;


            
            for (int i = 0; i < code_input_sentence.Length; i++)
            {
                string code_input_char = code_input_sentence.Substring(i,1);

                if (code_input_char=="1")
                {
                    next_item = nodes_list.Where(x => x.str == next_item.First().right.ToString()).ToList();
                    
                    if (next_item.First().periroity==0)
                    {
                        screen2.Text+=(next_item.First().str);
                         next_item = sorted_list_periroity.Take(1).ToList();
                    }
                }
                else if (code_input_char == "0")
                {
                    next_item = nodes_list.Where(x => x.str == next_item.First().left.ToString()).ToList();
                    
                    if (next_item.First().periroity == 0)
                    {
                        screen2.Text += (next_item.First().str);
                        next_item = sorted_list_periroity.Take(1).ToList();
                    }
                }

            }

            



        }



    }

    class nodes
    {

        public string str;
        public string left;
        public string right;
        public int count;
        public int periroity;
        public int check;
        public int num_of_char;//ترتيبه 

        static public nodes create_new_node(nodes n1, nodes n2, int periority, int last_num_of_char)
        {
            nodes new_node = new nodes();
            new_node.str = n1.str + n2.str;
            new_node.left = n1.str;
            new_node.right = n2.str;
            new_node.count = n1.count + n2.count;
            new_node.periroity = periority;
            new_node.check = 0;
            new_node.num_of_char = last_num_of_char;
            return new_node;
        }

        public void func()
        {


        }
    }

}
