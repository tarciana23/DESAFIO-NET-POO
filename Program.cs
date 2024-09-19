using Desafio_net_poo.Models;

Nokia celularNokia = new Nokia("NK78");
celularNokia.Ligar();

Iphone celularIphone = new Iphone("PH56");
celularIphone.ReceberLigacao();

celularNokia.InstalarAplicativo("Twitter");
celularIphone.InstalarAplicativo("Instagram");