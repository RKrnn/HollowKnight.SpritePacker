﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;

namespace HollowKnight.SpritePacker
{
    public class Language
    {
        #region Main Form

        public string Main_Title = "";
        public string Main_Label1 = "";
        public string Main_Label2 = "";
        public string Main_Label3 = "";
        public string Main_Label4 = "";
        public string Main_Label5 = "";
        public string Main_Label6 = "";
        public string Main_Label7 = "";
        public string Main_Label8 = "";
        public string Main_Label9 = "";
        public string Main_Label10 = "";
        public string Main_Label11 = "";
        public string Main_Label12 = "";
        public string Main_LinkLabel1 = "";
        public string Main_LinkLabel2 = "";
        public string Main_Button1 = "";
        public string Main_Button2 = "";
        public string Main_Button3 = "";
        public string Main_Button4 = "";
        public string Main_Button5 = "";
        public string Main_Button6 = "";
        public string Main_Button7 = "";
        public string Main_Button8 = "";
        public string Main_Button9 = "";
        public string Main_Button10 = "";
        public string Main_CheckBox1 = "";

        #endregion Main Form

        #region Message

        public string Message_Error01 = "";
        public string Message_Error02 = "";
        public string Message_Error03 = "";
        public string Message_Error04 = "";
        public string Message_Error05 = "";
        public string Message_Error06 = "";
        public string Message_01 = "";

        #endregion Message

        protected Dictionary<string, string> DicLanguage = new Dictionary<string, string>();

        public Language()
        {
            XmlLoad(GlobalData.SystemLanguage);
            BindLanguageText();
        }

        /// <summary>
        /// 读取XML放到内存
        /// </summary>
        /// <param name="language"></param>
        protected void XmlLoad(string language)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                //string address = AppDomain.CurrentDomain.BaseDirectory + "Languages\\" + language + ".xml";
                //doc.Load(address);
                Assembly assembly = GetType().Assembly;
                foreach (string res in assembly.GetManifestResourceNames())
                {
                    if (res.EndsWith(language + ".xml"))
                    {
                        doc.Load(assembly.GetManifestResourceStream(res));
                        XmlElement root = doc.DocumentElement;

                        XmlNodeList nodeLst1 = root.ChildNodes;
                        foreach (XmlNode item in nodeLst1)
                        {
                            DicLanguage.Add(item.Name, item.InnerText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BindLanguageText()
        {
            Main_Title = DicLanguage["Main_Title"];
            Main_Label1 = DicLanguage["Main_Label1"];
            Main_Label2 = DicLanguage["Main_Label2"];
            Main_Label3 = DicLanguage["Main_Label3"];
            Main_Label4 = DicLanguage["Main_Label4"];
            Main_Label5 = DicLanguage["Main_Label5"];
            Main_Label6 = DicLanguage["Main_Label6"];
            Main_Label7 = DicLanguage["Main_Label7"];
            Main_Label8 = DicLanguage["Main_Label8"];
            Main_Label9 = DicLanguage["Main_Label9"];
            Main_Label10 = DicLanguage["Main_Label10"];
            Main_Label11 = DicLanguage["Main_Label11"];
            Main_Label12 = DicLanguage["Main_Label12"];
            Main_LinkLabel1 = DicLanguage["Main_LinkLabel1"];
            Main_LinkLabel2 = DicLanguage["Main_LinkLabel2"];
            Main_Button1 = DicLanguage["Main_Button1"];
            Main_Button2 = DicLanguage["Main_Button2"];
            Main_Button3 = DicLanguage["Main_Button3"];
            Main_Button4 = DicLanguage["Main_Button4"];
            Main_Button5 = DicLanguage["Main_Button5"];
            Main_Button6 = DicLanguage["Main_Button6"];
            Main_Button7 = DicLanguage["Main_Button7"];
            Main_Button8 = DicLanguage["Main_Button8"];
            Main_Button9 = DicLanguage["Main_Button9"];
            Main_Button10 = DicLanguage["Main_Button10"];
            Main_CheckBox1 = DicLanguage["Main_CheckBox1"];

            Message_Error01 = DicLanguage["Message_Error01"];
            Message_Error02 = DicLanguage["Message_Error02"];
            Message_Error03 = DicLanguage["Message_Error03"];
            Message_Error04 = DicLanguage["Message_Error04"];
            Message_Error05 = DicLanguage["Message_Error05"];
            Message_Error06 = DicLanguage["Message_Error06"];
            Message_01 = DicLanguage["Message_01"];
        }
    }
}