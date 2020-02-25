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
using System.IO;
using System.Media;

namespace voice_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;           
            string cr=null;
            int pause = 260;
            char[] chars = str.ToArray();
            for(int i = 0; i< chars.Length; i++)
            {
                if (i <chars.Length - 1)//проверка на последний символ массива
                {
                    switch (chars[i] + chars[i + 1])
                    {
                        //проверка на пару: "согласная" + "гласная"
                        //"б"
                        case 'б' + 'а': { cr = @"b\ba"; i++; break; }
                        case 'б' + 'е': { cr = @"b\be"; i++; break; }
                        case 'б' + 'и': { cr = @"b\bi"; i++; break; }
                        case 'б' + 'о': { cr = @"b\bo"; i++; break; }
                        case 'б' + 'у': { cr = @"b\bu"; i++; break; }
                        case 'б' + 'ю': { cr = @"b\biu"; i++; break; }
                        case 'б' + 'э': { cr = @"b\bae"; i++; break; }
                        case 'б' + 'я': { cr = @"b\bia"; i++; break; }

                        //в случае одиночного символа
                        default:
                            switch (chars[i])
                            {
                                case 'а': cr = "a"; break;
                                case 'б': cr = "b"; break;
                                case 'в': cr = "v"; break;
                                case 'г': cr = "g"; break;
                                case 'д': cr = "d"; break;
                                case 'е': cr = "ie"; break;
                                case 'ё': cr = "ieo"; break;
                                case 'ж': cr = "gg"; break;
                                case 'з': cr = "z"; break;
                                case 'и': cr = "i"; break;
                                case 'й': cr = "tishina"; break;
                                case 'к': cr = "k"; break;
                                case 'л': cr = "l"; break;
                                case 'м': cr = "m"; break;
                                case 'н': cr = "n"; break;
                                case 'о': cr = "o"; break;
                                case 'п': cr = "p"; break;
                                case 'р': cr = "r"; break;
                                case 'с': cr = "s"; break;
                                case 'т': cr = "t"; break;
                                case 'у': cr = "u"; break;
                                case 'ф': cr = "f"; break;
                                case 'х': cr = "h"; break;
                                case 'ц': cr = "tc"; break;
                                case 'ч': cr = "tsh"; break;
                                case 'ш': cr = "sh"; break;
                                case 'щ': cr = "shsh"; break;
                                case 'ы': cr = "i"; break;
                                case 'э': cr = "ae"; break;
                                case 'ю': cr = "iu"; break;
                                case 'я': cr = "a"; break;
                                case ' ': { cr = "tishina"; } break;
                            }
                            break;
                    }               
                } 
                //в случае если символ последний
                else
                    switch (chars[i])
                    {
                        case 'а': cr = "a"; break;
                        case 'б': cr = "b"; break;
                        case 'в': cr = "v"; break;
                        case 'г': cr = "g"; break;
                        case 'д': cr = "d"; break;
                        case 'е': cr = "ie"; break;
                        case 'ё': cr = "ieo"; break;
                        case 'ж': cr = "gg"; break;
                        case 'з': cr = "z"; break;
                        case 'и': cr = "i"; break;
                        case 'й': cr = "tishina"; break;
                        case 'к': cr = "k"; break;
                        case 'л': cr = "l"; break;
                        case 'м': cr = "m"; break;
                        case 'н': cr = "n"; break;
                        case 'о': cr = "o"; break;
                        case 'п': cr = "p"; break;
                        case 'р': cr = "r"; break;
                        case 'с': cr = "s"; break;
                        case 'т': cr = "t"; break;
                        case 'у': cr = "u"; break;
                        case 'ф': cr = "f"; break;
                        case 'х': cr = "h"; break;
                        case 'ц': cr = "tc"; break;
                        case 'ч': cr = "tsh"; break;
                        case 'ш': cr = "sh"; break;
                        case 'щ': cr = "shsh"; break;
                        case 'ы': cr = "i"; break;
                        case 'э': cr = "ae"; break;
                        case 'ю': cr = "iu"; break;
                        case 'я': cr = "a"; break;
                        case ' ':
                            { cr = "tishina"; }
                            break;
                    }
                            player.SoundLocation = $@"fonems\"+ cr + ".wav";
                player.Play();
                
                Thread.Sleep(pause);
                
                
            }                                                              
        }
    }
}
