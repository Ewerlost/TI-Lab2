using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamencryption
{
    public class LFSR
    {
        private bool[] register;

        public LFSR(string initialBits)
        {
            if (initialBits.Length != 38)
                throw new ArgumentException("Длина регистра должна быть 38 битов.");

            register = new bool[38];
            for (int i = 0; i < 38; i++)
                register[i] = initialBits[i] == '1';
        }

        public byte NextBit()
        {
            bool feedback = register[37] ^ register[5] ^ register[4] ^ register[0];
            byte outputBit = register[37] ? (byte)1 : (byte)0;

            // Сдвиг влево
            for (int i = 37; i > 0; i--)
                register[i] = register[i - 1];

            register[0] = feedback;
            return outputBit;
        }

        public byte NextByte()
        {
            byte key = 0;
            for (int i = 0; i < 8; i++)
                key = (byte)((key << 1) | NextBit());

            return key;
        }
    }
}
