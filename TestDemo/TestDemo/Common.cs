using System;
using System.Collections.Generic;
using System.Text;

   internal class Common
    {
       internal static Dev_C_Sharp.Dev_C_Sharp devCommand = Dev_C_Sharp.Dev_C_Sharp.Instance;
       internal static int WriteGuestCard()
       {
           return devCommand.WriteCard(0, 0, "", "", 0, false);
       }
    }
   internal class CardType
   {
       /// <summary>
       /// Anthorizing card
       /// </summary>
       internal const int card_Authorization = 0x00;
       /// <summary>
       /// close card
       /// </summary>
       internal const int card_Lock = 0x00;
       /// <summary>
       /// record card
       /// </summary>
       internal const int card_Record = 0x01;
       /// <summary>
       /// room number card
       /// </summary>
       internal const int card_Room_number = 0x02;
       /// <summary>
       /// Time sync card
       /// </summary>
       internal const int card_Time = 0x03;
       /// <summary>
       /// lost card    lost card for certains cards
       /// </summary>
       internal const int card_Loss_report = 0x04;
       /// <summary>
       /// group number card
       /// </summary>
       internal const int card_Group_number_setting = 0x05;
       /// <summary>
       /// guest card
       /// </summary>
       internal const int card_Guest = 0x06;
       /// <summary>
       /// check out card
       /// </summary>
       internal const int card_Check_out = 0x07;
       /// <summary>
       /// group number card
       /// </summary>
       internal const int card_Group_number = 0x09;
       /// <summary>
       /// emergency card
       /// </summary>
       internal const int card_Emergency = 0x0a;
       /// <summary>
       /// control card
       /// </summary>
       internal const int card_Master_control = 0x0b;
       /// <summary>
       /// floor card
       /// </summary>
       internal const int card_Floor = 0x0c;
       /// <summary>
       /// building card
       /// </summary>
       internal const int card_Building= 0x0d;
   }