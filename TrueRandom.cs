using System.ComponentModel;
using System.Security.Cryptography;

class TrueRandom
{
    public double ReturnDouble()
    {
        var randomBytes = new byte[2];

        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
            int randomNumber = BitConverter.ToUInt16(randomBytes);

            return randomNumber / Math.Pow(2, 16);
        }
    }
}