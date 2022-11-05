using DesafioPOO.Models;


var nokia = new Nokia("32 98888-8888", "Nokia C01 Plus", "123456789", 600);
var iphone = new Iphone("32 97777-7777", "iPhone 14 Pro Max", "789456123", 900);


// var nubank = new App("Nubank", "Nu", 400);
// var tikTok = new App("TikTok", "TikTok Pte. Ltd.", 200);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Uber", "Uber Technologies, Inc", 300);
nokia.InstalarAplicativo("Nubank", "Nu", 400);


iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber", "Uber Technologies, Inc", 300);
iphone.InstalarAplicativo("Nubank", "Nu", 400);
iphone.InstalarAplicativo("TikTok", "TikTok Pte. Ltd.", 200);