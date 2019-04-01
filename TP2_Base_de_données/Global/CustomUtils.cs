using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global
{
    public static class CustomUtils
    {
        /// <summary>
        /// Makes the <see cref="Control.BackColor"/> of a control blink. The <see cref="Control.BackColor"/> will be reverted to its original value once the blinking is over.
        /// </summary>
        /// <param name="toBlink">The <see cref="Control.BackColor"/> of this control will be alternating between <paramref name="color1"/> and <paramref name="color2"/></param>
        /// <param name="color1">The first color of the blinking</param>
        /// <param name="color2">The second color of the blinking</param>
        /// <param name="msBlinkInterval">Time in milliseconds between each blink</param>
        /// <param name="blinkFor">How many times the color will alternate between <paramref name="color1"/> and <paramref name="color2"/></param>
        public static async void Blink(Control toBlink, Color color1, Color color2, int msBlinkInterval, int blinkFor)
        {
            Color originalBgColor = toBlink.BackColor;
            for (int i = 0; i <= blinkFor; ++i)
            {
                await Task.Delay(msBlinkInterval);
                toBlink.BackColor = toBlink.BackColor == color1 ? color2 : color1;
            }
            toBlink.BackColor = originalBgColor;
        }
    }
}
