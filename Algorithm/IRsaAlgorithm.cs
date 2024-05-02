using System.Numerics;

namespace Learning_RSA_Algorithm;

public interface IRsaAlgorithm
{
    /// <summary>
    /// P prime number
    /// </summary>
    BigInteger P { get; }

    /// <summary>
    /// Q prime number
    /// </summary>
    BigInteger Q { get; }

    /// <summary>
    /// Phi is (p -1)*(q - 1)
    /// </summary>
    public BigInteger Phi { get; }

    /// <summary>
    /// Modulos is P * Q
    /// </summary>
    public BigInteger Modulos { get; }

    /// <summary>
    /// Key used in the encryption process. Can be shared with anyone.
    /// </summary>
    string PublicKey { get; }

    /// <summary>
    /// Key used in the decryption process. Don't share it with anyone!
    /// </summary>
    string PrivateKey { get; }

    /// <summary>
    /// Encrypts the text with the public key and parse to base64 for better visualization
    /// </summary>
    /// <param name="plainText">Plain Text</param>
    /// <returns> Encrypted Text </returns>
    string Encrypt(string plainText);

    /// <summary>
    /// Decrypts the text with the private key.
    /// First, it converts the base64 string to UTF8 string and then split by space.
    /// </summary>
    /// <param name="base64EncryptedText">Encrypted Text Generated by Encrypt Method</param>
    /// <see cref="Encrypt"/>
    /// <returns> Decrypted Text </returns>
    string Decrypt(string base64EncryptedText);

    /// <summary>
    /// Minimum bit length for the prime numbers
    /// </summary>
    const int MinBitLenght = 64;
}