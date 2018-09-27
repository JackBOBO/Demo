﻿using System;
using System.IO;

namespace HexToBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexString = "0x504B0304140000000800947A634AFBFA10203D010000A80200000F001C00786C2F776F726B626F6F6B2E786D6C20A2180028A0140000000000000000000000000000000000000000008D914D4EC3301085F748DCC15895BAA26E4B52A0725A9576C3822221D4BD89C78DD5D88E6CF7EF6C2C381257C04968954A4864E7799EF7BDF1F8FBF38B4E0F2A473BB04E1A9DE041AF8F11E8D470A9D709DE7A71FB8091F34C73961B0D093E82C3D3C9F515DD1BBBF93066830240BBB14D70E67D3126C4A51928E67AA6001DEE84B18AF950DA353142C8141626DD2AD09E0CFBFD11B190331FC25D260B876B5A1B962B2C30EE3200AFF21AA598D438CC861015328755FD2A446AA91C762561EFAA3208A71794E2A9895C76D18A7F765415D24C8545BC306FE5212CA7D49E79D81D46762CC3E16D100D217D8C2116F7A3281E45F84C6FE028072135F065A09D031ADA6FCC6B01967963F1A45B27766F3AB3CE1D258DD6FFDDEFC7029A84A7D68459EAE50E4AA1E99FB79FC0AEE7865F98177F992F94721F949CFE67F203504B0304140000000800947A634AEAB2758DF5000000540200001A001C00786C2F5F72656C732F776F726B626F6F6B2E786D6C2E72656C7320A2180028A014000000000000000000000000000000000000000000B5924B4EC3301040AF62CD9E384EECA4AD9A76C3866DE9058C3D4EA2267664BBD09E8D0547E20A5845824462C1A6ABD1FC9E9E46F3F9FEB1DD5FC681BCA20FBDB30DB02C07825639DDDBB68173340F2BD8EFB6071C644C13A1EBA740D28A0D0D74314E1B4A83EA7094217313DAD431CE8F32A6D4B77492EA245BA4459E57D4CF19B06492E375C2FF109D31BDC247A7CE23DAF80798BE397F0A1D62047294BEC5D8C04F29D05B6059A20279D20D1C182F50AD050A53575C541C08BD9B5AE8A447FD1C7D3A6EF8D5A39761D99AE9AD725973C5CA5CE892637D5FBD781D70E6F59DCF648A42952FEBB26646332E84BEC9D0C56FECBE00504B0304140000000800947A634AF54335755D020000990D000018001C00786C2F776F726B7368656574732F7368656574312E786D6C20A2180028A0140000000000000000000000000000000000000000009597CB8E9B301486F795FA0E96F71D30E42EC868D2A817A9D22C5A754FC10968828D6C27699FAD8B3E525FA1069274121DFB84CD64B0F9FE73FC491CC97F7FFF491E7FD63B72E04A5752A4943D84947091CBA212DB94EECDE6DD8C126D3251643B29784A7F714D1F976FDF2447A95E74C9B9213641E8854A69694CB308029D97BCCEF4836CB8B07B1BA9EACCD847B50DE46653E57C2DF37DCD8509A2309C048AEF3263ABEBB26A34EDD3EEC9D28DE259D1B550EFFAA83AAB04B5CD11921495ADD01E8A28BE49E9135BAC594C49D0EF76D4F78A1F75F7FC7A85B407FB21E54BFBF0B948A935A24B79FCA8AAE24B25B8ED8D5D72829BA03E669D99EC9CABE491A80ED14DD61E8C2D46949426A5B10DCEF7DAC8FA13AFB6ED4AFB52F7B75FFED01DB65D3885D9B8BC0D7BB2AFD8757D7AFDB26BF70FCB30090EFFDF0FF2732381EDE4A6A9F8BA29FB1BE1B5E357B5A39BDA0CAE7D66573E36F2B3EF7D6CEC67D73E7674BFAFD195AF5B31A35391EBF831A204A626880C989A221A606A76BF80B157C0188C9F2302600A13005398009862033E9989D7C004CEC73E0B18C314C014A6C0D1A2E3EB83144CBD0AA6703EF285AE600C5300539802478B0306C1CCAB6006E7639300C6300530852970B4E8280629987B15CCE17CA4AD158C610A600A53E06871C03464A1D741BB0D55C006A283C32C38304C83038B06CC44C6FC1E185C019B8A0E0EF50063A80747970306238BFC1E22B802361A1D1CEA01C6500F8E2E074C4716FB3DC470056C3E3A38D4038CA11E1C5DA223F27427B8DC019226DBF2AFDCEC1BD2FEF7AC0A6EF3A5BD727D2BB958CBA3E86F134970B9512DFF01504B0304140002000800947A634ACC964BF460020000EA04000014001C00786C2F736861726564537472696E67732E786D6C20A2180028A0140000000000000000000000000000000000000000008D54CD8A1341107E9561EEB5D3D3D37FB324D983E013B80FD03FD5C948D213339365B3278505596541143CC9A2A7F524AE7871A36FB349F631EC20284C56C8A10FFD7D55FD557D5574EFE874324E4E70D65475E8A7F90149130CB6765518F6D3E3278F41A549D3EAE0F4B80ED84F17D8A4C9D1A0D7346D125343D34F476D3B3DCCB2C68E70A29B837A8A2132BE9E4D741BAFB361D64C67A85D33426C27E38C1222B289AE429AD87A1EDA7E4A659ACC43F56C8E8FFE0251A21AF4DAC1FDF5DBFB8B6FAB9BABF5F3EB5ED60E7AD916FFC3ADDF5DDEFDFA70777BFB5F6273B35C5DBDDEA1BF2F57AF3EAFDE5C6EAEBF76B9CDF27CB37CB9FE70BBBE3ADFFC7CBFF9F8A21B319CD7E32AE82E7CDCE0AC8BADBE7C5A5FFCE8A2442A5696C68343E7C0D0B200267801D278A12972668DE9E46CBD3E6CA6DAC6114433A3D409A68371359F6018264957010B4E90E614D0280565BC01335682D7B9708E1585236E2F85B3910EC3D37647403BC69CD51A94631E4A453C304FA30A524EBD15DA50B5670B8B6AA2C38E0047A399531ED0590625DF0A48A450E69213CE89115AEEEB91ABC370BC6B5221992B9114C0B58C3DB89C4709C1C038CB7DA1E329FDCEEC753DC4D04505F746092740D20241178C02CB73094EC4C20B2E05F2BC9B7336AF17D32E584A2B18A11C241708CC8A5897280C68B4D2F15C489FEFD7B58F6BB188B6769B7E389A532CB991029CB11674C97360B16E309296A6A0822822923DDF8A7E37D562FE80F640631C9B4202BE746ABBF7326EA5CFA34D441586685E6AD2CD791A3F2253EF8CCE28AD7CAEE2E83482D1DB97482980A25571338C8FCBFE2F278B9FD5E037504B03040A0000000000947A634A0B26E0E7D9010000D901000011001C00646F6350726F70732F636F72652E786D6C20A2180028A0140000000000000000000000000000000000000000003C3F786D6C2076657273696F6E3D22312E302220656E636F64696E673D227574662D3822207374616E64616C6F6E653D22796573223F3E0D0A3C63703A636F726550726F7065727469657320786D6C6E733A63703D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F7061636B6167652F323030362F6D657461646174612F636F72652D70726F706572746965732220786D6C6E733A64633D22687474703A2F2F7075726C2E6F72672F64632F656C656D656E74732F312E312F2220786D6C6E733A64637465726D733D22687474703A2F2F7075726C2E6F72672F64632F7465726D732F2220786D6C6E733A64636D69747970653D22687474703A2F2F7075726C2E6F72672F64632F64636D69747970652F2220786D6C6E733A7873693D22687474703A2F2F7777772E77332E6F72672F323030312F584D4C536368656D612D696E7374616E6365223E0D0A20203C64633A7469746C653E42E58DB0E7ABA0E79B98E782B9E5BE85E58A9EE5AEA1E689B93C2F64633A7469746C653E0D0A20203C64633A7375626A6563743E4D5346573A5365616C436865636B4D6173746F72417070726F76653C2F64633A7375626A6563743E0D0A3C2F63703A636F726550726F706572746965733E504B03040A0000000000947A634A2A064F2466020000660200000B001C005F72656C732F2E72656C7320A2180028A014000000000000000000000000000000000000000000EFBBBF3C3F786D6C2076657273696F6E3D22312E302220656E636F64696E673D227574662D38223F3E3C52656C6174696F6E736869707320786D6C6E733D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F7061636B6167652F323030362F72656C6174696F6E7368697073223E3C52656C6174696F6E7368697020547970653D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F7061636B6167652F323030362F72656C6174696F6E73686970732F6D657461646174612F636F72652D70726F7065727469657322205461726765743D22646F6350726F70732F636F72652E786D6C222049643D22526636656563386637396134363435323622202F3E3C52656C6174696F6E7368697020547970653D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F6F6666696365446F63756D656E742F323030362F72656C6174696F6E73686970732F657874656E6465642D70726F7065727469657322205461726765743D22646F6350726F70732F6170702E786D6C222049643D22526638643266396364383364343432333022202F3E3C52656C6174696F6E7368697020547970653D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F6F6666696365446F63756D656E742F323030362F72656C6174696F6E73686970732F6F6666696365446F63756D656E7422205461726765743D22786C2F776F726B626F6F6B2E786D6C222049643D22526232633036356362363234353466666622202F3E3C2F52656C6174696F6E73686970733E504B03040A0000000000947A634A21FB09D7E9000000E900000010001C00646F6350726F70732F6170702E786D6C20A2180028A0140000000000000000000000000000000000000000003C3F786D6C2076657273696F6E3D22312E302220656E636F64696E673D227574662D3822207374616E64616C6F6E653D22796573223F3E0D0A3C50726F7065727469657320786D6C6E733A76743D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F6F6666696365446F63756D656E742F323030362F646F6350726F70735654797065732220786D6C6E733D22687474703A2F2F736368656D61732E6F70656E786D6C666F726D6174732E6F72672F6F6666696365446F63756D656E742F323030362F657874656E6465642D70726F7065727469657322202F3E504B0304140000000800947A634A3A5FC4FDE6020000870D00000D001C00786C2F7374796C65732E786D6C20A2180028A014000000000000000000000000000000000000000000E5574B6EDB3010DD17E81D08EE1BFD6C270EA26491C24081FED078D12D6D5112518A34483AB573852E7B8F5EA0087A9976DD2B9494648AB214376E8C1468ED0D8743BE193E0E67463FBF7E3BBB5815145C63210967310C8E7C08309BF384B02C864B953E3B81402AC4124439C3315C63092FCE9F3E394B4EA55A537C9563AC800661F2348961AED4E2D4F3E43CC70592477C8199D6A55C14486951649E5C088C1269B615D40B7D7FE4158830A83101D0A829674A82395F3215C3A89AB68A5A2A657903AE11D53E071078AE82A10257AA1F5F3E7DBFFDDCA8CFBC16CC0ED0D0BF13F412513213E44F5077B8DA412DF5B37E231B415AD208A596B4814B9A56B8800BA414166CA2A7413D9EAE17FA5E99BEDDAD23355BF701CA045A07E1F0205892539240BBB4DA9C5D72CA0510D92C8693C9F3C8FC5DDA2AE2EA558A18468EC76178128CC26130084783283A1E8EA3E1201A0FFD28D29E1296E015D6D13B1AB4F8F75AAE3DCA71F4818E7DFF6F1D6723D8B89A7191E8DCB089ACD089AC4AE59E9BE254B5C357902CDF9A527CB115E25C295EB4E7128232CE106DC550CBE0DD0E945929862ADFE414AB9EBB44FBE50FD68CFADB4419A87B9CE430C634520F2387C1AEC0F621B7116D18CC31A557C69DF7A98D85C08985550AD8B29814EA4552BA6072D366A8C3A91E56A0B5E0595B2EB86BD0B1153DCCD62A6D19DD09133430E10360C206267261820ECC8682ADD3978CF4926DB5C0548F18BE36C5956A234B427510F43BDB22DA1A4A56FD1CEB7937625AE56C4741FB4DF5ED54CA6EF6DCA746755271B95997D18C1598299073416EB431E38A79CED0B4398ACC8D5CBD0AFD68F04ABDE30AA9B2FBD16C7D146831D593A5207341D887299F904A368D8BEE8BDE98CB6C0782E772B60F816137D7EFEE091EC660A702DDB7A41EAC0ADD5587FE89DBDCF91C7A6E73ABC77B9CEBED6B31FED7EBADC736212A34D39F34ADD4AB772638454BAAA65619C366FC0A2764598CEDAAB7E49AAB7A55337E69FA8760547961AC361F4FE7BF00504B0304140000000800947A634A4E993FD22F010000D103000013001C005B436F6E74656E745F54797065735D2E786D6C20A2180028A014000000000000000000000000000000000000000000AD934D4E03310C85AF32CA16CDA4658110EAB40B600B95E00251E2E944CD9F62B7B46763C191B8029E142A8110B46A575162FB7BCF4EF2FEFA36996DBCABD690D1C6D08A71331215041D8D0D8B56ACA8ABAFC56C3A79DE26C08A5303B6A2274A3752A2EEC12B6C6282C0912E66AF88B7792193D24BB50079391A5D491D0341A09A0686984EEEA0532B47D5FD868F77B25C2EAADB5DDE20D50A9592B35A1187E53A981F2275EC3AABC144BDF25CD260CAA00CF600E45D53D6C62B1B2E0A58FEAA99C1E171A29F5D355C5972B0B709F7128F3CC46C0D547395E94179E6C98D932F312F8B2194651937E76D76CFFFCF08F62A8379A2CC378B6736F18DFDA71106CC734CC8AF22C3F12EBEAE60A8AE13832093850325997D72DF303C2003E650F161F0B47570F68917E85E5A960F3AFD00504B01022D00140000000800947A634AFBFA10203D010000A80200000F0000000000000000000000000000000000786C2F776F726B626F6F6B2E786D6C504B01022D00140000000800947A634AEAB2758DF5000000540200001A0000000000000000000000000086010000786C2F5F72656C732F776F726B626F6F6B2E786D6C2E72656C73504B01022D00140000000800947A634AF54335755D020000990D00001800000000000000000000000000CF020000786C2F776F726B7368656574732F7368656574312E786D6C504B01022D00140002000800947A634ACC964BF460020000EA04000014000000000000000000000000007E050000786C2F736861726564537472696E67732E786D6C504B01022D000A0000000000947A634A0B26E0E7D9010000D901000011000000000000000000000000002C080000646F6350726F70732F636F72652E786D6C504B01022D000A0000000000947A634A2A064F2466020000660200000B00000000000000000000000000500A00005F72656C732F2E72656C73504B01022D000A0000000000947A634A21FB09D7E9000000E90000001000000000000000000000000000FB0C0000646F6350726F70732F6170702E786D6C504B01022D00140000000800947A634A3A5FC4FDE6020000870D00000D000000000000000000000000002E0E0000786C2F7374796C65732E786D6C504B01022D00140000000800947A634A4E993FD22F010000D103000013000000000000000000000000005B1100005B436F6E74656E745F54797065735D2E786D6C504B050600000000090009003F020000D71200000000";
            var fileByteArray = ConvertToBytes(hexString);

            File.WriteAllBytes(@"C:\temp\what the fuck.xlsx", fileByteArray);

            Console.ReadKey();
        }
        private static byte[] ConvertToBytes(string hexString)
        {
            hexString = hexString.TrimStart('0', 'x').Trim();

            if (hexString.Length % 2 != 0)
            {
                throw new Exception("hex string error!");
            }

            byte[] bytes = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            }

            return bytes;
        }
    }
}