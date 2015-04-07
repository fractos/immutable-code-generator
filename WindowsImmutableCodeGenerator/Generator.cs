using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsImmutableCodeGenerator
{
    public class Generator
    {
        public string Generate(string codeTemplate, string codeNamespace, string codeClassName, IDictionary<string, string> codeProperties)
        {
            TokenList tokenList = new TokenList();

            tokenList.AddOrUpdate("#Classname#", codeClassName);
            tokenList.AddOrUpdate("#ClassnameLower#", codeClassName.ToLower());
            tokenList.AddOrUpdate("#Namespace#", codeNamespace);


            tokenList.AddOrUpdate("#PrivatePropertiesReadOnly#",
                String.Join("\r\n\t\t", codeProperties.Select(kvp => String.Format("private readonly {0} _{1};", kvp.Value, kvp.Key)))
                );
            
            tokenList.AddOrUpdate("#PublicPropertiesReadable#",
                String.Join("\r\n\t\t", codeProperties.Select(kvp => String.Format("public {0} {1} {{ get {{ return _{1}; }} }}", kvp.Value, kvp.Key)))
                );

            tokenList.AddOrUpdate("#PublicPropertiesWritable#",
                String.Join("\r\n\t\t\t", codeProperties.Select(kvp => String.Format("public {0} {1} {{ get; set; }}", kvp.Value, kvp.Key)))
                );

            
            tokenList.AddOrUpdate("#ConstructorLoadFromPeer#",
                String.Join("\r\n\t\t\t\t", codeProperties.Select(kvp => String.Format("this.{0} = {1}.{0};", kvp.Key, codeClassName.ToLower())))
                );

            tokenList.AddOrUpdate("#ConstructorLoadPrivatesFromPeer#",
                String.Join("\r\n\t\t\t", codeProperties.Select(kvp => String.Format("this._{0} = {1}.{0};", kvp.Key, codeClassName.ToLower())))
                );

            tokenList.AddOrUpdate("#ConstructorLoadFromArguments#",
                String.Join("\r\n\t\t\t\t", codeProperties.Select(kvp => String.Format("this.{0} = {1};", kvp.Key, kvp.Key.ToLower())))
                );

            tokenList.AddOrUpdate("#ConstructorLoadPrivatesFromArguments#",
                String.Join("\r\n\t\t\t", codeProperties.Select(kvp => String.Format("this._{0} = {1};", kvp.Key, kvp.Key.ToLower())))
                );

            tokenList.AddOrUpdate("#PropertiesAsArgumentDefinitions#",
                String.Join(", ", codeProperties.Select(kvp => String.Format("{0} {1}", kvp.Value, kvp.Key.ToLower())))
                );

            tokenList.AddOrUpdate("#PropertiesAsArgumentsWithThis#",
                String.Join(", ", codeProperties.Select(kvp => String.Format("this.{0}", kvp.Key)))
                );

            /*
            writer.WriteStartElement("prize");

            writer.WriteElementString("title", this.Title);
            writer.WriteElementString("prizeid", this.PrizeID.ToString());
            writer.WriteElementString("prizedrawid", this.PrizeDrawID.ToString());
            writer.WriteElementString("prizeno", this.PrizeNo.ToString());
            writer.WriteElementString("prizedescription", this.PrizeDescription);

            writer.WriteEndElement();
            */

            string xmlPropertyWrites =
                    String.Join("\r\n\t\t\t",
                                codeProperties.Select(kvp =>
                                                    String.Format("writer.WriteElementString(\"{0}\", this.{1}{2});",
                                                                    kvp.Key.ToLower(), kvp.Key, (kvp.Value == "string" ? String.Empty : ".ToString()"))
                                    ));

            tokenList.AddOrUpdate("#ToXmlSection#",
                                  String.Format("writer.WriteStartElement(\"{0}\");\r\n\r\n\t\t\t{1}\r\n\r\n\t\t\twriter.WriteEndElement();\r\n",
                                                codeClassName.ToLower(), xmlPropertyWrites));


            /*
            writer.WriteStartObject();
            writer.WritePropertyName("title");
            writer.WriteValue(this.Title);
            writer.WritePropertyName("prizeid");
            writer.WriteValue(this.PrizeID);
            writer.WritePropertyName("prizedrawid");
            writer.WriteValue(this.PrizeDrawID);
            writer.WritePropertyName("prizeno");
            writer.WriteValue(this.PrizeNo);
            writer.WritePropertyName("prizedescription");
            writer.WriteValue(this.PrizeDescription);
            writer.WriteEndObject();
            */

            string jsonPropertyWrites =
                String.Join("\r\n\t\t\t",
                            codeProperties.Select(kvp =>
                                                  String.Format("writer.WritePropertyName(\"{0}\");\r\n\t\t\twriter.WriteValue(this.{1});",
                                                                kvp.Key.ToLower(), kvp.Key)
                                ));

            tokenList.AddOrUpdate("#ToJsonSection#",
                                  String.Format("writer.WriteStartObject();\r\n\r\n\t\t\t{0}\r\n\r\n\t\t\twriter.WriteEndObject();\r\n",
                                                jsonPropertyWrites));

            return tokenList.Replace(codeTemplate);
        }
    }
}
