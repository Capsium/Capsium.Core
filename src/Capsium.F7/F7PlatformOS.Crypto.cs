using Capsium.Core;

namespace Capsium;

public partial class F7PlatformOS : IPlatformOS
{
    /// <summary>
    /// Performs RSA decryption of a value using the Capsium device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <returns>The decrypted value</returns>
    public byte[] RsaDecrypt(byte[] encryptedValue)
    {
        return Interop.Nuttx.CapsiumCloudDecryptRsa(encryptedValue);
    }

    /// <summary>
    /// Performs AES decryption of a value using the Capsium device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <param name="iv">The initialization vector to use for decryption</param>
    /// <param name="key">The key used for encrypting the buffer</param>
    /// <returns>The decrypted value</returns>
    public byte[] AesDecrypt(byte[] encryptedValue, byte[] key, byte[] iv)
    {
        return Interop.Nuttx.CapsiumCloudDecryptAES(encryptedValue, key, iv);
    }
}
