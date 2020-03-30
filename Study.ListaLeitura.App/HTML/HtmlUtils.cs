using System.IO;

public class HtmlUtils
{
    public static string CarregarArquivoHTML(string nomeArquivo)
    {
        var nomeArquivoCompleto = $"HTML/{nomeArquivo}.html";
        var retorno = string.Empty;

        using(var sr = File.OpenText(nomeArquivoCompleto))
            retorno = sr.ReadToEnd();
            
        return retorno;
    }
}