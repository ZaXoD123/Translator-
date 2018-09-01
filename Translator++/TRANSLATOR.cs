using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator__
{
    
    class TRANSLATOR
    {
        
        int count = 0;
        [STAThread]
        public virtual string translate(string eng, string rus)
        {
            if (count > 1) { count = 0; return "строка в разных раскладках"; }
            StringBuilder builder = new StringBuilder(Clipboard.GetText());
            for (int i = 0; i < builder.Length; i++)
            {
                try
                {
                    builder.Insert(i, eng[rus.IndexOf(builder[i])].ToString(), 1);
                    builder.Remove(i + 1, 1);
                }
                catch
                {
                    if ((rus.IndexOf(builder[i]) == -1)&&(eng.IndexOf(builder[i]) != -1)){ count++; return translate(rus,eng); }
                    continue;
                }
                
            }
            count = 0;
            Clipboard.SetText(builder.ToString());
            return builder.ToString();
        }
        
    }
}
