﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone(numero: "789456", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");