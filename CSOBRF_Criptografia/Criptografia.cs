namespace CSOBRF_Criptografia
{
    public class Criptografia
    {
        #region Variaveis Internas da Classe
        string encryptedText = string.Empty;
        string decryptedText = string.Empty;
        string hashedText = string.Empty;
        #endregion

        #region Criptografar
        /// <summary>
        /// Recebe uma String e Retorna ela Criptografada pelo algoritmo simétrico de Rijndael
        /// </summary>
        /// <param name="Valor">String para ser Criptografada</param>
        /// <returns>Retorna String já criptografada</returns>
        public string Criptografar(string Valor)
        {
            string key = Valor;
            Crypt _crypt = new Crypt((CryptProvider)4);
            _crypt.Key = "FuturaDataClose"; //nota - você pode trocar essa chave para uma pessoal, só não esqueça de trocar no "descriptografar"
            encryptedText = _crypt.Encrypt(key);

            //06072016 - Fernando, Randon nas duas primeiras e últimas letras yeah
            string duasPrimeiras = "CR"; //essas duas letras serão inseridas no inicio (você pode trocar ou remover)
            string duasUltimas = "FD"; //essas duas letras serão inseridas no fim (você pode trocar ou remover)

            return duasPrimeiras + encryptedText + duasUltimas; //adiciono duas palavras ao começo e duas ao fim só pra complicar

        }//fim método Criptografar
        #endregion

        #region Descriptografar
        /// <summary>
        /// Recebe uma String Criptografada e retorna ela Descriptografada
        /// </summary>
        /// <param name="Valor">String para ser Criptografada</param>
        /// <returns>Retorna String já criptografada</returns>
        public string Descriptografar(string Valor)
        {
            string key = Valor.Substring(2, Valor.Length-4); //começo no 2, ignoro os últimos 4 (pra incluir o FD)
            Crypt _crypt = new Crypt((CryptProvider)4);
            _crypt.Key = "FuturaDataClose"; //nota - você pode trocar essa chave para uma pessoal, só não esqueça de trocar no "criptografar"
            decryptedText = _crypt.Decrypt(key);
            return decryptedText;
        }//fim método Descriptografar
        #endregion
    }//fim namespace
}//fim classe
