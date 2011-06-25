using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AC {
   public partial class Form1 : Form {

      Dictionary<string, string> acDict = new Dictionary<string, string>();

      public Form1()
      {
         InitializeComponent();
      }

      private void areaCodeMaskedTextBox_TextChanged(object sender, EventArgs e)
      {
         string txt = areaCodeMaskedTextBox.Text;

         try {
            stateTextBox.Text = acDict[txt];
         } catch {
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         acDict.Add("201", "New Jersey:");
         acDict.Add("202", "Washington, D.C.");
         acDict.Add("203", "Connecticut");         
         acDict.Add("204", "Manitoba");
         acDict.Add("205", "Alabama");
         acDict.Add("206", "Washington");
         acDict.Add("207", "Maine");
         acDict.Add("208", "Idaho");
         acDict.Add("209", "California");
         acDict.Add("210", "Texas");
         acDict.Add("211", "Local community info");
         acDict.Add("212", "New York");
         acDict.Add("213", "California");
         acDict.Add("214", "Texas");
         acDict.Add("215", "Pennsylvania");
         acDict.Add("216", "Cleveland");
         acDict.Add("217", "Illinois");
         acDict.Add("218", "Minnesota");
         acDict.Add("219", "Indiana");
         acDict.Add("224", "Illinois");
         acDict.Add("225", "Louisiana");
         acDict.Add("226", "Ontario");
         acDict.Add("228", "Mississippi");
         acDict.Add("229", "Georgia");
         acDict.Add("231", "Michigan");
         acDict.Add("234", "Ohio");
         acDict.Add("236", "Virginia");
         acDict.Add("239", "Florida");
         acDict.Add("240", "Maryland");
         acDict.Add("242", "Bahamas");
         acDict.Add("246", "Barbados");
         acDict.Add("248", "Michigan");
         acDict.Add("250", "British Columbia");
         acDict.Add("251", "Alabama");
         acDict.Add("252", "North Carolina");
         acDict.Add("253", "Washington");
         acDict.Add("254", "Texas");
         acDict.Add("256", "Alabama");
         acDict.Add("260", "Indiana");
         acDict.Add("262", "Wisconsin");
         acDict.Add("264", "Anguilla");
         acDict.Add("267", "Pennsylvania");
         acDict.Add("268", "Antigua and Barbuda");
         acDict.Add("269", "Michigan");
         acDict.Add("270", "Kentucky");
         acDict.Add("276", "Virginia");
         acDict.Add("278", "Michigan");
         acDict.Add("281", "Texas");
         acDict.Add("283", "Ohio");
         acDict.Add("284", "British Virgin Islands");
         acDict.Add("289", "Ontario");
         acDict.Add("301", "Maryland");
         acDict.Add("302", "Delaware");
         acDict.Add("303", "Colorado");
         acDict.Add("304", "West Virginia");
         acDict.Add("305", "Florida");
         acDict.Add("306", "Saskatchewan");
         acDict.Add("307", "Wyoming");
         acDict.Add("308", "Nebraska");
         acDict.Add("309", "Illinois");
         acDict.Add("310", "California");
         acDict.Add("312", "Illinois");
         acDict.Add("313", "Michigan");
         acDict.Add("314", "Missouri");
         acDict.Add("315", "New York");
         acDict.Add("316", "Kansas");
         acDict.Add("317", "Indiana");
         acDict.Add("318", "Louisiana");
         acDict.Add("319", "Iowa");
         acDict.Add("320", "Minnesota");
         acDict.Add("321", "Florida");
         acDict.Add("323", "California");
         acDict.Add("325", "Texas");
         acDict.Add("330", "Ohio");
         acDict.Add("331", "Illinois");
         acDict.Add("334", "Alabama");
         acDict.Add("336", "North Carolina");
         acDict.Add("337", "Louisiana");
         acDict.Add("339", "Massachusetts");
         acDict.Add("340", "US Virgin Islands");
         acDict.Add("341", "California");
         acDict.Add("345", "Cayman Islands");
         acDict.Add("347", "New York");
         acDict.Add("351", "Massachusetts");
         acDict.Add("352", "Florida");
         acDict.Add("360", "Washington");
         acDict.Add("361", "Texas");
         acDict.Add("369", "California");
         acDict.Add("380", "Ohio");
         acDict.Add("385", "Utah");
         acDict.Add("386", "Florida");
         acDict.Add("401", "Rhode Island");
         acDict.Add("402", "Nebraska");
         acDict.Add("403", "Alberta");
         acDict.Add("404", "Atlanta");
         acDict.Add("405", "Oklahoma");
         acDict.Add("406", "Montana");
         acDict.Add("407", "Florida");
         acDict.Add("408", "California");
         acDict.Add("409", "Texas");
         acDict.Add("410", "Maryland");
         acDict.Add("412", "Pennsylvania");
         acDict.Add("413", "Massachusetts");
         acDict.Add("414", "Wisconsin");
         acDict.Add("415", "California");
         acDict.Add("416", "Ontario");
         acDict.Add("417", "Missouri");
         acDict.Add("418", "Quebec");
         acDict.Add("419", "Ohio");
         acDict.Add("423", "Tennessee");
         acDict.Add("424", "California");
         acDict.Add("425", "Washington");
         acDict.Add("430", "Texas");
         acDict.Add("432", "Texas");
         acDict.Add("434", "Virginia");
         acDict.Add("435", "Utah");
         acDict.Add("438", "Quebec");
         acDict.Add("440", "Ohio");
         acDict.Add("441", "Bermuda");
         acDict.Add("442", "California");
         acDict.Add("443", "Maryland");
         acDict.Add("450", "Quebec");
         acDict.Add("464", "Illinois");
         acDict.Add("469", "Texas");
         acDict.Add("470", "Georgia");
         acDict.Add("473", "Grenada");
         acDict.Add("475", "Connecticut");
         acDict.Add("478", "Georgia");
         acDict.Add("479", "Arkansas");
         acDict.Add("480", "Arizona");
         acDict.Add("484", "Pennsylvania");
         acDict.Add("501", "Arkansas");
         acDict.Add("502", "Kentucky");
         acDict.Add("503", "Oregon");
         acDict.Add("504", "Louisiana");
         acDict.Add("505", "New Mexico");
         acDict.Add("506", "New Brunswick");
         acDict.Add("507", "Minnesota");
         acDict.Add("508", "Massachusetts");
         acDict.Add("509", "Washington");
         acDict.Add("510", "California");
         acDict.Add("512", "Texas");
         acDict.Add("513", "Ohio");
         acDict.Add("514", "Canada");
         acDict.Add("515", "Iowa");
         acDict.Add("516", "New York");
         acDict.Add("517", "Michigan");
         acDict.Add("518", "New York");
         acDict.Add("519", "Ontario");
         acDict.Add("520", "Arizona");
         acDict.Add("530", "California");
         acDict.Add("540", "Virginia");
         acDict.Add("541", "Oregon");
         acDict.Add("551", "New Jersey");
         acDict.Add("557", "Missouri");
         acDict.Add("559", "California");
         acDict.Add("561", "Florida");
         acDict.Add("562", "California");
         acDict.Add("563", "Iowa");
         acDict.Add("564", "Washington");
         acDict.Add("567", "Ohio");
         acDict.Add("570", "Pennsylvania");
         acDict.Add("571", "Virginia");
         acDict.Add("573", "Missouri");
         acDict.Add("574", "Indiana");
         acDict.Add("580", "Oklahoma");
         acDict.Add("585", "New York");
         acDict.Add("586", "Michigan");
         acDict.Add("601", "Mississippi");
         acDict.Add("602", "Arizona");
         acDict.Add("603", "New Hampshire");
         acDict.Add("604", "British Columbia");
         acDict.Add("605", "South Dakota");
         acDict.Add("606", "Kentucky");
         acDict.Add("607", "New York");
         acDict.Add("608", "Wisconsin");
         acDict.Add("609", "New Jersey");
         acDict.Add("610", "Pennsylvania");
         acDict.Add("612", "Minnesota");
         acDict.Add("613", "Ontario");
         acDict.Add("614", "Ohio");
         acDict.Add("615", "Tennessee");
         acDict.Add("616", "Michigan");
         acDict.Add("617", "Massachusetts");
         acDict.Add("618", "Illinois");
         acDict.Add("619", "California");
         acDict.Add("620", "Kansas");
         acDict.Add("623", "Arizona");
         acDict.Add("626", "California");
         acDict.Add("628", "California");
         acDict.Add("630", "Illinois");
         acDict.Add("631", "New York");
         acDict.Add("636", "Missouri");
         acDict.Add("641", "Iowa");
         acDict.Add("646", "New York");
         acDict.Add("647", "Canada");
         acDict.Add("649", "Turks & Caicos Islands");
         acDict.Add("650", "California");
         acDict.Add("651", "Cent. Minnesota");
         acDict.Add("660", "Missouri");
         acDict.Add("661", "California");
         acDict.Add("662", "Mississippi");
         acDict.Add("664", "Montserrat");
         acDict.Add("669", "California");
         acDict.Add("670", "Mariana Islands");
         acDict.Add("671", "Guam");
         acDict.Add("678", "Georgia");
         acDict.Add("679", "Michigan");
         acDict.Add("682", "Texas");
         acDict.Add("684", "American Samoa");
         acDict.Add("689", "Florida");
         acDict.Add("701", "North Dakota");
         acDict.Add("702", "Nevada");
         acDict.Add("703", "Virginia");
         acDict.Add("704", "North Carolina");
         acDict.Add("705", "Ontario");
         acDict.Add("706", "Georgia");
         acDict.Add("707", "California");
         acDict.Add("708", "Illinois");
         acDict.Add("709", "Newfoundland and Labrador");
         acDict.Add("710", "US Government");
         acDict.Add("711", "Telecommunications Relay Services");
         acDict.Add("712", "Iowa");
         acDict.Add("713", "Texas");
         acDict.Add("714", "California");
         acDict.Add("715", "Wisconsin");
         acDict.Add("716", "New York");
         acDict.Add("717", "Pennsylvania");
         acDict.Add("718", "New York");
         acDict.Add("719", "Colorado");
         acDict.Add("720", "Colorado");
         acDict.Add("724", "Pennsylvania");
         acDict.Add("727", "Florida");
         acDict.Add("731", "Tennessee");
         acDict.Add("732", "New Jersey");
         acDict.Add("734", "Michigan");
         acDict.Add("737", "Texas");
         acDict.Add("740", "Ohio");
         acDict.Add("747", "California");
         acDict.Add("754", "Florida");
         acDict.Add("757", "Virginia");
         acDict.Add("758", "St. Lucia");
         acDict.Add("760", "California");
         acDict.Add("762", "Georgia");
         acDict.Add("763", "Minnesota");
         acDict.Add("764", "California");
         acDict.Add("765", "Indiana");
         acDict.Add("767", "Dominica");
         acDict.Add("769", "Mississippi");
         acDict.Add("770", "Georgia");
         acDict.Add("772", "Florida");
         acDict.Add("773", "Illinois");
         acDict.Add("774", "Massachusetts");
         acDict.Add("775", "Nevada");
         acDict.Add("778", "British Columbia");
         acDict.Add("779", "Illinois");
         acDict.Add("780", "Alberta");
         acDict.Add("781", "Massachusetts");
         acDict.Add("784", "St. Vincent & Grenadines");
         acDict.Add("785", "Kansas");
         acDict.Add("786", "Florida");
         acDict.Add("787", "Puerto Rico");
         acDict.Add("800", "US/Canada toll free");
         acDict.Add("801", "Utah");
         acDict.Add("802", "Vermont");
         acDict.Add("803", "South Carolina");
         acDict.Add("804", "Virginia");
         acDict.Add("805", "California");
         acDict.Add("806", "Texas");
         acDict.Add("807", "Ontario");
         acDict.Add("808", "Hawaii");
         acDict.Add("809", "Dominican Republic");
         acDict.Add("810", "Michigan");
         acDict.Add("811", "Reserved for special applications");
         acDict.Add("812", "Indiana");
         acDict.Add("813", "Florida");
         acDict.Add("814", "Pennsylvania");
         acDict.Add("815", "Illinois");
         acDict.Add("816", "Missouri");
         acDict.Add("817", "Texas");
         acDict.Add("818", "California");
         acDict.Add("819", "Quebec");
         acDict.Add("822", "US/Canada toll free");
         acDict.Add("828", "North Carolina");
         acDict.Add("829", "Dominican Republic");
         acDict.Add("830", "Texas");
         acDict.Add("831", "California");
         acDict.Add("832", "Texas");
         acDict.Add("833", "US/Canada toll free");
         acDict.Add("835", "Pennsylvania");
         acDict.Add("843", "South Carolina");
         acDict.Add("844", "US/Canada toll free");
         acDict.Add("845", "New York");
         acDict.Add("847", "Illinois");
         acDict.Add("848", "New Jersey");
         acDict.Add("850", "Florida");
         acDict.Add("855", "US/Canada toll free");
         acDict.Add("856", "New Jersey");
         acDict.Add("857", "Massachusetts");
         acDict.Add("858", "California");
         acDict.Add("859", "Kentucky");
         acDict.Add("860", "Connecticut");
         acDict.Add("862", "New Jersey");
         acDict.Add("863", "Florida");
         acDict.Add("864", "South Carolina");
         acDict.Add("865", "Tennessee");
         acDict.Add("866", "US/Canada toll free");
         acDict.Add("867", "Yukon, Northwest Territories, Nunavut");
         acDict.Add("868", "Trinidad and Tobago");
         acDict.Add("869", "St. Kitts");
         acDict.Add("870", "Arkansas");
         acDict.Add("872", "Illinois");
         acDict.Add("876", "Jamaica");
         acDict.Add("877", "US/Canada toll free");
         acDict.Add("878", "Pennsylvania");
         acDict.Add("880", "Paid Toll-Free Service");
         acDict.Add("881", "Paid Toll-Free Service");
         acDict.Add("882", "Paid Toll-Free Service");
         acDict.Add("888", "US/Canada toll free");
         acDict.Add("898", "VoIP service");
         acDict.Add("900", "US toll calls");
         acDict.Add("901", "Tennessee");
         acDict.Add("902", "Nova Scotia");
         acDict.Add("903", "Texas");
         acDict.Add("904", "Florida");
         acDict.Add("906", "Michigan");
         acDict.Add("907", "Alaska");
         acDict.Add("908", "New Jersey");
         acDict.Add("909", "California");
         acDict.Add("910", "North Carolina");
         acDict.Add("911", "Emergency");
         acDict.Add("912", "Georgia");
         acDict.Add("913", "Kansas");
         acDict.Add("914", "New York");
         acDict.Add("915", "Texas");
         acDict.Add("916", "California");
         acDict.Add("917", "New York");
         acDict.Add("918", "Oklahoma");
         acDict.Add("919", "North Carolina");
         acDict.Add("920", "Wisconsin");
         acDict.Add("925", "California");
         acDict.Add("927", "Florida");
         acDict.Add("928", "Arizona");
         acDict.Add("931", "Tennessee");
         acDict.Add("935", "California");
         acDict.Add("936", "Texas");
         acDict.Add("937", "Ohio");
         acDict.Add("939", "Puerto Rico");
         acDict.Add("940", "Texas");
         acDict.Add("941", "Florida");
         acDict.Add("947", "Michigan");
         acDict.Add("949", "California");
         acDict.Add("951", "California");
         acDict.Add("952", "Minnesota");
         acDict.Add("954", "Florida");
         acDict.Add("956", "Texas");
         acDict.Add("957", "New Mexico");
         acDict.Add("959", "Connecticut");
         acDict.Add("970", "Colorado");
         acDict.Add("971", "Oregon");
         acDict.Add("972", "Texas");
         acDict.Add("973", "New Jersey");
         acDict.Add("975", "Missouri");
         acDict.Add("978", "Massachusetts");
         acDict.Add("979", "Texas");
         acDict.Add("980", "North Carolina");
         acDict.Add("984", "North Carolina");
         acDict.Add("985", "Louisiana");
         acDict.Add("989", "Michigan");
      }
   }
}