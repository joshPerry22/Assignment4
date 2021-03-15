﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace MerkleRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string tx1Hash = "aad28e85f31ae79339b49d114d7c1811d2c667681a1904ebbc326842a0a81985";
            string tx2Hash = "b963d3426088217357b146d5600817c54f93c2ea1a23126988e36460015ffc0e";
            string tx3Hash = "82498f4da1e1b662b02e95150dc9fd64307ee96b35657f75c7abd82530168ce3";
            string tx4Hash = "ceecfd37686a3ed1759d3cef25e412a800fc8e8846154dbe2a2d72b2af3e3b64";

            string oneAndTwo = tx1Hash + tx2Hash;
            byte [] firstBytes = Encoding.ASCII.GetBytes(oneAndTwo);
            byte [] hashFirstBytes = SHA256.Create().ComputeHash(firstBytes);
            byte[] hashSecondBytes = SHA256.Create().ComputeHash(hashFirstBytes);
            string donePartOne =  BitConverter.ToString(hashSecondBytes).Replace("-", "");

            string threeAndFour = tx3Hash + tx4Hash;
            byte[] thirdBytes = Encoding.ASCII.GetBytes(threeAndFour);
            byte[] hashThirdtBytes = SHA256.Create().ComputeHash(thirdBytes);
            byte[] hashFourthBytes = SHA256.Create().ComputeHash(hashThirdtBytes);
            string donePartTwo =  BitConverter.ToString(hashFourthBytes).Replace("-", "");


            string merkle = donePartOne + donePartTwo;
            byte[] merkleBytes = Encoding.ASCII.GetBytes(merkle);
            byte[] merkleFirstBytes = SHA256.Create().ComputeHash(merkleBytes);
            byte[] merkleSecondBytes = SHA256.Create().ComputeHash(merkleFirstBytes);
            string merkleRoot = BitConverter.ToString(merkleSecondBytes).Replace("-", "");

            Console.WriteLine(merkleRoot);






            
        }
    }
}
