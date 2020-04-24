using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.IO;

namespace zadanie3
{
    public class RSA
    {
        public BigInteger PublicKey { get; set; }
        public BigInteger PrivateKey { get; set; }
        public BigInteger N { get; set; }
        public BigInteger Ø { get; set; }
        public BigInteger p { get; set; }
        public BigInteger q { get; set; }
        public BigInteger E { get; set; }
        public BigInteger D { get; set; }


        static Random Random = new Random();
        //https://primes.utm.edu/lists/2small/100bit.html
        int[] ks128 = { 159, 173, 233, 237, 275, 357, 675, 713, 797, 1193 };
        int[] ks129 = { 25, 315, 403, 613, 735, 741, 805, 1113, 1185, 1365 };
        int[] ks130 = { 5, 27, 113, 173, 315, 417, 425, 447, 455, 585 };
        int[] ks131 = { 69, 181, 271, 315, 385, 421, 427, 615, 625, 681 };
        #region primes128
        List<BigInteger> primes128 = new List<BigInteger>();
        //https://asecuritysite.com/encryption/getprimen
        string[] primes128String =
        {
            "329258270496183812540219852041216667767",
            "275999865996184890228162348637043256727",
            "277762687318984836694433930805045847019",
            "232688162572904984594778572079361059329",
            "294629130892510671920902184158688526901",
            "264952614882933510140181250463391281447",
            "189403040545896259961152457589946502527",
            "296316277020122767734478797975395295739",
            "298473639502914503288692461886569989723",
            "254475200733528925092476062312505414713",
            "173227557618635299602549904641218872717",
            "303232442610496524347122077895157123977",
            "174905898678167380695295119209557329547",
            "237284773123931512450861158367206615193",
            "330067945672106545543706928476018260757",
            "290729061316019100086860815210912394441",
            "172564888416984416358591106126237434059",
            "307631111402108409045893449350724237601"
        };
        #endregion
        public RSA()
        {
            foreach (var item in primes128String) primes128.Add(BigInteger.Parse(item));
        }

        public void GenerateEncryptionKeys()
        {
            do
            {
                p = primes128[Random.Next(primes128.Count)];
                q = primes128[Random.Next(primes128.Count)];
            } while (BigInteger.Equals(p, q));

            Ø = BigInteger.Multiply(BigInteger.Subtract(p, BigInteger.One), BigInteger.Subtract(q, BigInteger.One));
            N = BigInteger.Multiply(p, q);

            E = new BigInteger(65537);
            D = EEA(E, Ø);

            //todo generate public and private key
            PublicKey = E;
            PrivateKey = D;
        }

        public BigInteger EncryptMessage(BigInteger input)
        {
            return BigInteger.ModPow(input, PublicKey, N);
        }

        public BigInteger DecryptMessage(BigInteger input)
        {
            return BigInteger.ModPow(input, PrivateKey, N);
        }

        public string EncryptMessage(string input)
        {
            var byteArray = Encoding.ASCII.GetBytes(input);
            var encrypted = BigInteger.ModPow(new BigInteger(byteArray), PublicKey, N);
            return Convert.ToBase64String(encrypted.ToByteArray());
        }

        public string DecryptMessage(string input)
        {
            var byteArray = Convert.FromBase64String(input);
            var decrypted = BigInteger.ModPow(new BigInteger(byteArray), PrivateKey, N);
            return Encoding.ASCII.GetString(decrypted.ToByteArray());
        }

        public string EncryptFile(string path)
        {
            var byteArray = File.ReadAllBytes(path);
            var encrypted = BigInteger.ModPow(new BigInteger(byteArray), PublicKey, N);
            return Convert.ToBase64String(encrypted.ToByteArray());
        }

        public string DecryptFile(string path)
        {
            var byteArray = Convert.FromBase64String(File.ReadAllText(path));
            var decrypted = BigInteger.ModPow(new BigInteger(byteArray), PrivateKey, N);
            return Encoding.ASCII.GetString(decrypted.ToByteArray());
        }


        //https://eduinf.waw.pl/inf/alg/001_search/0009.php
        private static BigInteger EEA(BigInteger a, BigInteger b)
        {
            BigInteger u, w, x, z, q;
            u = 1; w = a;
            x = 0; z = b;
            while (w > BigInteger.Zero)
            {
                if (w < z)
                {
                    q = u; u = x; x = q;
                    q = w; w = z; z = q;
                }
                q = w / z;
                u -= q * x;
                w -= q * z;
            }
            if (z == 1)
            {
                if (x < 0) x += b;
                return x;
            }
            return BigInteger.Zero;
        }
    }
}
