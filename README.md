Fernando Passaia - 25/11/2018 - Visual Studio 2017 Community.
Note: This Framework was developed for Brazilian or Portuguese Speakers, because all methods and code have the Portuguese language for nomeclature. If your language is Spanish, you will probably understand it without any problem.

A Muitos anos atrás eu iniciei o Desenvolvimento desse Framework (em 2008), com várias classes para tratamento de strings, de decimais, datas,
métodos de arredondamento de valores, tratamento de imagens, impressão em impressoras de 40 colunas (Daruma, Bematech, etc), ECF (Cupom Fiscal), FTP, criptografia, manipulação de arquivos, Consulta CEP (WebService Correios) e vários outros. Além disso possuo uma classe para ATIVAÇÃO de Software:

O intuíto dessa classe é fornecer métodos para Gerar chaves e Contra-Chaves de Ativação, para inserir em Softwares e fazer um tipo de "Software Original". Por exemplo: Se você tiver um Software Windows Forms, você pode pedir que esse Software gere uma chave a cada X prazo (5 dias, 15, 30, 60, 180) e seu cliente tenha que entrar em contato (ou em algum software online) para gerar essa chave. A Chave é única (pois pega o Serial do HD, via kernel), e além disso randômica, uma parte é gerada baseada num Random de 1 a 999. Ou seja: Sempre pedirá uma chave diferente. Ou seja:

Ele só poderá ter a chave se estiver em dia com "financeiro" ou algum outro critério que você tenha em sua empresa. Cabe a você armazenar no seu sistema de quanto em quanto tempo o sistema deve pedir a chave, se está travado, destravado, e enfim. Crie tabelas e utilize Status e Datas para chamar a validação.

----------------------------------------------------------------------------------------------------------------------------------------------

Essas Dlls foram Desenvolvidas a partir de 2008 no .Net Framework 2.0, e estão até hoje no mesmo Framework. Deixei dessa maneira para que ficassem levese possam ser interligadas a praticamente qualquer sistema. Mais uma informação: Essas Dlls antes de abrir tinham o nome de Dll"FuturaData" alguma coisa,que é o nome da minha empresa, eventualmente pode haver algum resquício (limpei elas, mas pode haver alguma referência a ser arrumada ainda). Apontei essas dlls para compilação em c:\CSharpOpenBrFramework, então basta criar esse diretório que tudo será jogado lá de maneira fácil.

----------------------------------------------------------------------------------------------------------------------------------------------

ExemploConsumoWinForms: Irei disponibilizar um Projeto Windows Forms que irá mostrar como consumir vários recursos desse CSharpOpenBrFramework. Além de mostrar o uso das principais funções, também terei outros exemplos de várias coisas interessantes em Windows Forms C#.

----------------------------------------------------------------------------------------------------------------------------------------------

Eu irei manter abaixo um LOG das implementações que estou subindo, assim como na documentação do GitHub. Irei também disponibiliza um Projeto WindowsForms de TCC que desenvolvi em 2012 (FuturaDataTCC) C# + MVC + SQL Server que será integrado a essa DLL. Também irei disponibilizar um software Asp.Net CoreOpen-Source para Suporte a Clientes (CRM). Vamos lá:

----------------------------------------------------------------------------------------------------------------------------------------------

25/11/2018: Subindo todas as dlls organizadas. Próximo passo é um Windows Forms consumindo todas as rotinas.
