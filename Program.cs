﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Atividade001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Goku";
            string nome2 = "Airton";

            int idade1 = 36;
            int idade2 = 42;
            int Qcafe1 = 30;
            int Qcafe2 = 14;
            int Qcafetotal = Qcafe1 + Qcafe2;  //Q = quantidade
            int Qcafefaltante1 = 200 - Qcafe1;
            int Qcafefaltante2 = 200 - Qcafe2;

            Boolean C1 = true; // C= condição
            Boolean C2 = false;



            Console.WriteLine("   Aula 03 - Atividade com variáveis");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("  Olá!");
            Console.WriteLine("  Bem-vindo ao sistema de usuários do Conradito");
            Console.WriteLine("\n \n \n");
            Console.WriteLine(" Abaixo estão as informações dos usuários cadastrados no nosso sistema");
            Console.WriteLine("\n \n");
            Console.WriteLine("------ Lista de usuários:");
            Console.WriteLine($"  1 - Nome :{nome1}, idade :{idade1}.É cliente{C1}");
            Console.WriteLine($"  1 - Nome :{nome2}, idade :{idade2}.É cliente{C2}");
            Console.WriteLine("\n \n");
            Console.WriteLine("------ Quantidade de cafés");
            Console.WriteLine($"  O Cliente {nome1} já tomou {Qcafe1} café!");
            Console.WriteLine($"  O Cliente {nome2} já tomou {Qcafe2} cafe");
            Console.WriteLine("\n \n");
            Console.WriteLine("------ Soma de cafés tomados");
            Console.WriteLine($"  Juntos os cliente {nome1} e {nome2} tomaram {Qcafetotal} Cafés!");
            Console.WriteLine("\n \n");
            Console.WriteLine("------ Quantos cafés falta para chegar em 200?");
            Console.WriteLine($"  Faltam {Qcafefaltante1} para {nome1}");
            Console.WriteLine($"  Faltam {Qcafefaltante2} para {nome2}");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("------ fIM DO SISTEMA DE CONSULTAS");
            Console.WriteLine("----Obrigado e volte sempre!! ");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("*****************,,.....     .,((((((,.,((((*/,,(((,,**,.*..   . ....(.....(((((((((#(####(((,*(#(#%%%(///((###(///((%&@@@@@@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@&#%&&&%##/*,*,../&&&*.**,,*/(//*....,/,**\r\n**********************,,..,,..,((((((.,(((((*/(,,(//,**, /..    .... */.....*###%##(#####(#((((((((((##%%(##(#((#####((((((//(%@@@@@@@@@@&@@@@@@@@@@@@@@@@@@@@@&&#(//**/(((///**#%#/   ...//**.....,..*,\r\n****************/*///*******,,*((((((,/((((/((((,,#((,./**,. /* ...........,%,/#%%#/(##(((####(/////(////*******/////*(///((###(((#%&@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%#/**,**/////***(#******,,,,, ,,,,....\r\n****************/**************(((((((((((((((((((,/(##/(,/*./##*..(. ..*..,#(#/.(((/(#////,.,/(#####%%%%%%%%%%%&&&&&%%#(/*,**(*//((#((%@@@@@@@@@@@@@@@@@@@@@@&&&#%%%%(..........,*/  ,//,.,,**/**. ....\r\n*********/***********/////*****(((((((((((((((((((((#((((*((,#(#(,#,,,......####/((***..*(#%%%&&%%%%%&&&&&&&&&&&&&&&&%%%%%%%%&&#*.,,*/(#(#%@@@@@@@@@@@&@@@&&&@&%&&%&#///,..   ...,,*    ., ,**,*,,/...  \r\n*,,,,,.,,,,,*********///******,((((((((((((((((((((((((#((#(#####(####.,//..(#((**,,(%%#((((((###%%%%&&&&&&&&&&&&&&&%%%%%%##(///**/(/,,**/(((%&&&@&&#(((*(%&%%###%&&&%%(/*..,,,,,***,,,**,/*,,**.,,,**,,\r\n,,,.**..,*******************,..(((((((((((((((((((((((#(#########(###(((*((*//*,*(/***//(##%%%&%%%&%&&&&&&&&&&&&&&&&%%%%%######((((///**,,**(((%&%%%#%%#//#####((////*/(**//*****,,(**/***.,,,.....,**/*\r\n.,,.....,,,,*************,**,..(((((((((((((((((((((((###((############((#(*,,*(***/(###((((((((((##%%%&&%%%&&&&&%%%##(((((((########%#(*,,,,*/((*,,,,,**((####///((////((/****///***/*/*.,**,..,*,,..,.\r\n,,...,,,,.,,************,.*.,..(((((((((((((((((((((####(#######(##(//(##(*,.,**(##########(((//////((#%%&&&&&&%%##(///(((##%%%%%%%######%(/,.**///,,,,,,*(##(((*/((/,.., ......*,//*,.(,**,,*//*,..,*//\r\n..... ...,,,,****,..,,,,.. .,..(#((((((((((((((((((((########(/*(##(/,,*(*,.,/(####((##%%%%###(((//*//((#%%%%%%%##((((((((((###%%%###(((((((((,,,/((*,*,*,,. ...  .,///((//////////(/////*/*//**%%(%#((/\r\n...   ... ..,,,,........  .    (((((((((((((#(#(#(((#(#(###/###(/(#####(,,,*((((((((##%%%%##(((((((((((##%%%%&%%########(/****.,,...,*/((((((((,,,*(/*,.,,,,...../*,*... ......,,****,,**/(((((/*/#(#(##\r\n          ...,,,,,,....      . (((((((((((((#(((#(((#(((#((###########(**,/////////*,...*,,,((///((#####%%%%&&&%%%%#####((((/(((((/////**//(((((*.,,*/*,,*//*,.***/*/(,.****,....,.  .  . .  .*/**//((%%\r\n      .. .,,**,.      ...    .,((((((((((((((#########################/*,,/////**,,**///////((/(######%%%%&&&&&&&%%#####%%%%%#((((((((###(#######(..,,/(*,,.,///(///////******/(/,/,.**,,,....****(((#&#\r\n...,.,,,,,,..   .   ....  .  ..((((((((((((((((######################(*,,///(((((///*****/(####%####(((((########((((####%%%%%&&&%%%%%%%%%%%%###(((,,***,,*,....*///////***////***..,,,,,,**,...../##%%#\r\n,,,.   ..     ..    .....,,,,,,((((((((((((((((####################,.*/,*/((((##%%%%%%%%%%%%%%%##(((((/**////////***//((###%%%%%%%&&&&&&&&&%%%%##((/.,*/*.....................(*..,,,******//****(*...,(\r\n           .,,,. ...   .,,. .. (((((((((((((####################/./#/(,.*/((###%%%%%%%%%%%%%%%##((///*. .,,*******,...,*//(########%%%%%%%%%%%%###(/..***.. ...          .. .(*,,,******//////***///(/#%\r\n.,. ..  .      .  .      ..    (((((((#########################/(###*#*,,//((###%%%%%%%%%%%######/**,,,,**/(((#(////****//(###%%%#(##############(((..***.....,..      .,,,,,/(,...*///*////////**//,. .\r\n                              .(((((((((##########################(*##/,.*//((##########((/(##(((//*****//****///*****/*////(#%%%####(((((###(((((((,.,** ..    ... ...,*****,*//*,,,,.......   ,/***/*.\r\n  ..,.                         (((((((((((((#(((((#(#(#########(#(/####*,,*//((((((((((((((////***************//*,*/*//////**////((#####(//(((((((((,.,**....      ......,.    .....,,........... .*////\r\n.......                        (((((((((((((((((((((((###########/((#((/,.,/////(((((((((#(///*//*****//((///////************///////*////((/((((((((,.,,,...  . .,*,.,,**,,. ..,***/**,.... .**,,,*///**\r\n...   ...    ...... ......     /((((((((((((((((((((#########((((((#((((*,,*/////(((///***********,,,,,****,.        .,**/*,,,,,,,***//**/((((((((((,.**,,... ..*//,,,,*,,...... ....,*,... ..........,.\r\n.....  .     ......   ...      /((((((((((((((((((((((((((((((((((((((((/,,,////////*****/**,,....,*//(#%%%*...,,,,,....,/((//*,...,,*****///((((((/*,,*,.,,..,.,*.,,,,. ......     ,,   .,,.... .......\r\n......    ................     ///((((((((((((((((((((((((((((((((((((((/(*,,///////*,,,***,,......,,.....,,****////****,,.,,,****/////*/**/////((/*.,,*,,**,....,,,....,....    ..  ...,*, .   ..... ..\r\n..,,...  .. ...  ..    ..     .///////(((((((((((((((((((((((((((((((((((*/**//*******,,,,**/////*/////((/(((##############((((((((((///****///////,,,*,,,,.....  .  ,/*,,,...,,*,,.            ...   .*\r\n.,........                   ..//////////((((((((((((((((((((((((((((((((/////**/*****,,**/((((///////(((#%%%%%%%%#######((((((((((((((//****////****,,....,.. ..      **,,,,.**,......        .....*/((\r\n........                    ...*//////////((((((((((((((((((((((((((((((((((/////*******///((((((///////////////////////////////((((((//**********,*,*,...,.,*,.,,.     ,,,,,,,,,,,,........,*,,,,,,,*/#\r\n..                    .....,,,,*//////////((((((((((((((((((((((((((((((((////(///*******////////////*********************//////(((((///***,,,,*,*,,,,..   ,**,,,,*,.   ..,,,,***,,.........,*//*//**//#\r\n          ........,,,,**********///////////////((((((((((((((((((((((((((/(//////(/*,,,,,***/////////*****,,,,,,,,,,********//////////*,,,,...,,*,,,,,.  ...,***,,***,.   .,*,.,//*,,. .**/****////(//*/\r\n....,,,,,,,******************((/****////////*******/*/***/***///*/////(((//**//******,,,,,,,,**,,******,,,,,,,,,*******************,,,,.......,,,,,,,.,..    .,**,,*,. .... .*,,...,,. ,***/**//((((((((\r\n*****************************///***////((((((((((((((((#(((((((((#########(////*,,,,,,,.......,,,,,,,,,,,****,,,,,,********,*,,,,,,..........,,,,,,,,.,..,       .*,. .,.,*//((///**,..,**(/*//((///((((\r\n*********************//***,,**//***,*///(((/(((/(((///((((((((((((((((((((((//**,,,,,.............,,,,,,,,,,,,,,,,,,,,,,,,,,,.................,,,***///,,*.......   ....*/**/*****///*.,***/**,,***//(((\r\n**************/****,,*////***************************************,,,,,,.....,,,,,,..........,................................................,,,***//(((,..........,,.,,,***//(((//**,.,(#*,.,,,,*//((((\r\n*//**///**,*,,*/((//***////***/**/*/**,*********************/(/,,..............,,*,..,,,,,...................................................,,,**///(##(................,#%#######((/,,*/(*...,*///////\r\n***,,,,*/(((//***////*******//***,*,************/((###########/,,...............,**,,,,...................................  ..............,,,,***///((##(,................(%%%%%%#####%%######(//////***\r\n,*/((///***//////*****//*/*,,*,,**///***///((##################,,...............*//**,,,........................  .......   ..............,,,*////((((###*................,%%%%%%%%%%%%%%%%%%%%######/**\r\n/*****/*///****//////,,,*,,*//*****//*/(#######################/................,(((/**,,,..........   .....  ..                 .......,,,,**////((((###*.................(%%%%%%%%%%%%%%%%%%%%%%%%%###\r\n/*///**,*///////,.**,.*//***********(#####%%%%%%%%%%%%%%%%%%%%##...  ...........,(((///***,,.........   ....          ..        .....,,,*,,**/////(((((##*.................,#%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n****///////,,**,,*/////*/*////////(#######%%%%%%%%%%%%%%%%%%%###,..        ....../(((////****,,,,..... .  ....         .     ........,,****//////(((((##(,..................*%%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n/////*,,**,,**///////////******/(#######%%%%%%%%%%%%%%%%%%%#####,.. . . . .......*(((/////*******,,,..........................,,,,,****/////////((((####(....................(%%%%%%%%%%%%%%%%%%%%%%%%%%\r\n,.,**,,***///*******//////*/**/((#######%%%%%%%%%%%%%%%%%#######,..    ..........,/((((////***********,,,,,,,,.,,,,,,,,,,,,,,,,********///////((((((####/.....................#%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.ReadKey();  




        }
    }
}
