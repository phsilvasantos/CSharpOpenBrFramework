using System;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;
using CSOBRF_Validacoes;

namespace CSOBRF_Criptografia
{    
    public class AtivacaoSoftware
    {
        string[] arrayChaves = { "C4IYF2ZYU5", "C18IPF12ZO", "C27IPF21ZO", "C36IPF30ZO", "C45IPF39ZO", "C54IPF48ZO", "C63IPF57ZO", "C72IPF66ZO", "C81IPF75ZO", "C90IPF84ZO", "C99IPF93ZO", "C108IF102Z", "C117IF111Z", "C126IF120Z", "C135IF129Z", "C144IF138Z", "C153IF147Z", "C162IF156Z", "C171IF165Z", "C180IF174Z", "C189IF183Z", "C198IF192Z", "C207IF201Z", "C216IF210Z", "C225IF219Z", "C234IF228Z", "C243IF237Z", "C252IF246Z", "C261IF255Z", "C270IF264Z", "C279IF273Z", "C288IF282Z", "C297IF291Z", "C306IF300Z", "C315IF309Z", "C324IF318Z", "C333IF327Z", "C342IF336Z", "C351IF345Z", "C360IF354Z", "C369IF363Z", "C378IF372Z", "C387IF381Z", "C396IF390Z", "C405IF399Z", "C414IF408Z", "C423IF417Z", "C432IF426Z", "C441IF435Z", "C450IF444Z", "C459IF453Z", "C468IF462Z", "C477IF471Z", "C486IF480Z", "C495IF489Z", "C504IF498Z", "C513IF507Z", "C522IF516Z", "C531IF525Z", "C540IF534Z", "C549IF543Z", "C558IF552Z", "C567IF561Z", "C576IF570Z", "C585IF579Z", "C594IF588Z", "C603IF597Z", "C612IF606Z", "C621IF615Z", "C630IF624Z", "C639IF633Z", "C648IF642Z", "C657IF651Z", "C666IF660Z", "C675IF669Z", "C684IF678Z", "C693IF687Z", "C702IF696Z", "C711IF705Z", "C720IF714Z", "C729IF723Z", "C738IF732Z", "C747IF741Z", "C756IF750Z", "C765IF759Z", "C774IF768Z", "C783IF777Z", "C792IF786Z", "C801IF795Z", "C810IF804Z", "C819IF813Z", "C828IF822Z", "C837IF831Z", "C846IF840Z", "C855IF849Z", "C864IF858Z", "C873IF867Z", "C882IF876Z", "C891IF885Z", "C900IF894Z", "C900IF894Z", "C507IF508Z", "C512IF513Z", "C517IF518Z", "C522IF523Z", "C527IF528Z", "C532IF533Z", "C537IF538Z", "C542IF543Z", "C547IF548Z", "C552IF553Z", "C557IF558Z", "C562IF563Z", "C567IF568Z", "C572IF573Z", "C577IF578Z", "C582IF583Z", "C587IF588Z", "C592IF593Z", "C597IF598Z", "C602IF603Z", "C607IF608Z", "C612IF613Z", "C617IF618Z", "C622IF623Z", "C627IF628Z", "C632IF633Z", "C637IF638Z", "C642IF643Z", "C647IF648Z", "C652IF653Z", "C657IF658Z", "C662IF663Z", "C667IF668Z", "C672IF673Z", "C677IF678Z", "C682IF683Z", "C687IF688Z", "C692IF693Z", "C697IF698Z", "C702IF703Z", "C707IF708Z", "C712IF713Z", "C717IF718Z", "C722IF723Z", "C727IF728Z", "C732IF733Z", "C737IF738Z", "C742IF743Z", "C747IF748Z", "C752IF753Z", "C757IF758Z", "C762IF763Z", "C767IF768Z", "C772IF773Z", "C777IF778Z", "C782IF783Z", "C787IF788Z", "C792IF793Z", "C797IF798Z", "C802IF803Z", "C807IF808Z", "C812IF813Z", "C817IF818Z", "C822IF823Z", "C827IF828Z", "C832IF833Z", "C837IF838Z", "C842IF843Z", "C847IF848Z", "C852IF853Z", "C857IF858Z", "C862IF863Z", "C867IF868Z", "C872IF873Z", "C877IF878Z", "C882IF883Z", "C887IF888Z", "C892IF893Z", "C897IF898Z", "C902IF903Z", "C907IF908Z", "C912IF913Z", "C917IF918Z", "C922IF923Z", "C927IF928Z", "C932IF933Z", "C937IF938Z", "C942IF943Z", "C947IF948Z", "C952IF953Z", "C957IF958Z", "C962IF963Z", "C967IF968Z", "C972IF973Z", "C977IF978Z", "C982IF983Z", "C987IF988Z", "C992IF993Z", "C997IF998Z", "C997IF998Z", "C1410F1413", "C1417F1420", "C1424F1427", "C1431F1434", "C1438F1441", "C1445F1448", "C1452F1455", "C1459F1462", "C1466F1469", "C1473F1476", "C1480F1483", "C1487F1490", "C1494F1497", "C1501F1504", "C1508F1511", "C1515F1518", "C1522F1525", "C1529F1532", "C1536F1539", "C1543F1546", "C1550F1553", "C1557F1560", "C1564F1567", "C1571F1574", "C1578F1581", "C1585F1588", "C1592F1595", "C1599F1602", "C1606F1609", "C1613F1616", "C1620F1623", "C1627F1630", "C1634F1637", "C1641F1644", "C1648F1651", "C1655F1658", "C1662F1665", "C1669F1672", "C1676F1679", "C1683F1686", "C1690F1693", "C1697F1700", "C1704F1707", "C1711F1714", "C1718F1721", "C1725F1728", "C1732F1735", "C1739F1742", "C1746F1749", "C1753F1756", "C1760F1763", "C1767F1770", "C1774F1777", "C1781F1784", "C1788F1791", "C1795F1798", "C1802F1805", "C1809F1812", "C1816F1819", "C1823F1826", "C1830F1833", "C1837F1840", "C1844F1847", "C1851F1854", "C1858F1861", "C1865F1868", "C1872F1875", "C1879F1882", "C1886F1889", "C1893F1896", "C1900F1903", "C1907F1910", "C1914F1917", "C1921F1924", "C1928F1931", "C1935F1938", "C1942F1945", "C1949F1952", "C1956F1959", "C1963F1966", "C1970F1973", "C1977F1980", "C1984F1987", "C1991F1994", "C1998F2001", "C2005F2008", "C2012F2015", "C2019F2022", "C2026F2029", "C2033F2036", "C2040F2043", "C2047F2050", "C2054F2057", "C2061F2064", "C2068F2071", "C2075F2078", "C2082F2085", "C2089F2092", "C2096F2099", "C2096F2099", "C2710F2711", "C2719F2720", "C2728F2729", "C2737F2738", "C2746F2747", "C2755F2756", "C2764F2765", "C2773F2774", "C2782F2783", "C2791F2792", "C2800F2801", "C2809F2810", "C2818F2819", "C2827F2828", "C2836F2837", "C2845F2846", "C2854F2855", "C2863F2864", "C2872F2873", "C2881F2882", "C2890F2891", "C2899F2900", "C2908F2909", "C2917F2918", "C2926F2927", "C2935F2936", "C2944F2945", "C2953F2954", "C2962F2963", "C2971F2972", "C2980F2981", "C2989F2990", "C2998F2999", "C3007F3008", "C3016F3017", "C3025F3026", "C3034F3035", "C3043F3044", "C3052F3053", "C3061F3062", "C3070F3071", "C3079F3080", "C3088F3089", "C3097F3098", "C3106F3107", "C3115F3116", "C3124F3125", "C3133F3134", "C3142F3143", "C3151F3152", "C3160F3161", "C3169F3170", "C3178F3179", "C3187F3188", "C3196F3197", "C3205F3206", "C3214F3215", "C3223F3224", "C3232F3233", "C3241F3242", "C3250F3251", "C3259F3260", "C3268F3269", "C3277F3278", "C3286F3287", "C3295F3296", "C3304F3305", "C3313F3314", "C3322F3323", "C3331F3332", "C3340F3341", "C3349F3350", "C3358F3359", "C3367F3368", "C3376F3377", "C3385F3386", "C3394F3395", "C3403F3404", "C3412F3413", "C3421F3422", "C3430F3431", "C3439F3440", "C3448F3449", "C3457F3458", "C3466F3467", "C3475F3476", "C3484F3485", "C3493F3494", "C3502F3503", "C3511F3512", "C3520F3521", "C3529F3530", "C3538F3539", "C3547F3548", "C3556F3557", "C3565F3566", "C3574F3575", "C3583F3584", "C3592F3593", "C3592F3593", "C3615F3612", "C3624F3621", "C3633F3630", "C3642F3639", "C3651F3648", "C3660F3657", "C3669F3666", "C3678F3675", "C3687F3684", "C3696F3693", "C3705F3702", "C3714F3711", "C3723F3720", "C3732F3729", "C3741F3738", "C3750F3747", "C3759F3756", "C3768F3765", "C3777F3774", "C3786F3783", "C3795F3792", "C3804F3801", "C3813F3810", "C3822F3819", "C3831F3828", "C3840F3837", "C3849F3846", "C3858F3855", "C3867F3864", "C3876F3873", "C3885F3882", "C3894F3891", "C3903F3900", "C3912F3909", "C3921F3918", "C3930F3927", "C3939F3936", "C3948F3945", "C3957F3954", "C3966F3963", "C3975F3972", "C3984F3981", "C3993F3990", "C4002F3999", "C4011F4008", "C4020F4017", "C4029F4026", "C4038F4035", "C4047F4044", "C4056F4053", "C4065F4062", "C4074F4071", "C4083F4080", "C4092F4089", "C4101F4098", "C4110F4107", "C4119F4116", "C4128F4125", "C4137F4134", "C4146F4143", "C4155F4152", "C4164F4161", "C4173F4170", "C4182F4179", "C4191F4188", "C4200F4197", "C4209F4206", "C4218F4215", "C4227F4224", "C4236F4233", "C4245F4242", "C4254F4251", "C4263F4260", "C4272F4269", "C4281F4278", "C4290F4287", "C4299F4296", "C4308F4305", "C4317F4314", "C4326F4323", "C4335F4332", "C4344F4341", "C4353F4350", "C4362F4359", "C4371F4368", "C4380F4377", "C4389F4386", "C4398F4395", "C4407F4404", "C4416F4413", "C4425F4422", "C4434F4431", "C4443F4440", "C4452F4449", "C4461F4458", "C4470F4467", "C4479F4476", "C4488F4485", "C4497F4494", "C4497F4494", "C4013F4016", "C4021F4024", "C4029F4032", "C4037F4040", "C4045F4048", "C4053F4056", "C4061F4064", "C4069F4072", "C4077F4080", "C4085F4088", "C4093F4096", "C4101F4104", "C4109F4112", "C4117F4120", "C4125F4128", "C4133F4136", "C4141F4144", "C4149F4152", "C4157F4160", "C4165F4168", "C4173F4176", "C4181F4184", "C4189F4192", "C4197F4200", "C4205F4208", "C4213F4216", "C4221F4224", "C4229F4232", "C4237F4240", "C4245F4248", "C4253F4256", "C4261F4264", "C4269F4272", "C4277F4280", "C4285F4288", "C4293F4296", "C4301F4304", "C4309F4312", "C4317F4320", "C4325F4328", "C4333F4336", "C4341F4344", "C4349F4352", "C4357F4360", "C4365F4368", "C4373F4376", "C4381F4384", "C4389F4392", "C4397F4400", "C4405F4408", "C4413F4416", "C4421F4424", "C4429F4432", "C4437F4440", "C4445F4448", "C4453F4456", "C4461F4464", "C4469F4472", "C4477F4480", "C4485F4488", "C4493F4496", "C4501F4504", "C4509F4512", "C4517F4520", "C4525F4528", "C4533F4536", "C4541F4544", "C4549F4552", "C4557F4560", "C4565F4568", "C4573F4576", "C4581F4584", "C4589F4592", "C4597F4600", "C4605F4608", "C4613F4616", "C4621F4624", "C4629F4632", "C4637F4640", "C4645F4648", "C4653F4656", "C4661F4664", "C4669F4672", "C4677F4680", "C4685F4688", "C4693F4696", "C4701F4704", "C4709F4712", "C4717F4720", "C4725F4728", "C4733F4736", "C4741F4744", "C4749F4752", "C4757F4760", "C4765F4768", "C4773F4776", "C4781F4784", "C4789F4792", "C4797F4800", "C4797F4800", "C1206F1207", "C1208F1209", "C1210F1211", "C1212F1213", "C1214F1215", "C1216F1217", "C1218F1219", "C1220F1221", "C1222F1223", "C1224F1225", "C1226F1227", "C1228F1229", "C1230F1231", "C1232F1233", "C1234F1235", "C1236F1237", "C1238F1239", "C1240F1241", "C1242F1243", "C1244F1245", "C1246F1247", "C1248F1249", "C1250F1251", "C1252F1253", "C1254F1255", "C1256F1257", "C1258F1259", "C1260F1261", "C1262F1263", "C1264F1265", "C1266F1267", "C1268F1269", "C1270F1271", "C1272F1273", "C1274F1275", "C1276F1277", "C1278F1279", "C1280F1281", "C1282F1283", "C1284F1285", "C1286F1287", "C1288F1289", "C1290F1291", "C1292F1293", "C1294F1295", "C1296F1297", "C1298F1299", "C1300F1301", "C1302F1303", "C1304F1305", "C1306F1307", "C1308F1309", "C1310F1311", "C1312F1313", "C1314F1315", "C1316F1317", "C1318F1319", "C1320F1321", "C1322F1323", "C1324F1325", "C1326F1327", "C1328F1329", "C1330F1331", "C1332F1333", "C1334F1335", "C1336F1337", "C1338F1339", "C1340F1341", "C1342F1343", "C1344F1345", "C1346F1347", "C1348F1349", "C1350F1351", "C1352F1353", "C1354F1355", "C1356F1357", "C1358F1359", "C1360F1361", "C1362F1363", "C1364F1365", "C1366F1367", "C1368F1369", "C1370F1371", "C1372F1373", "C1374F1375", "C1376F1377", "C1378F1379", "C1380F1381", "C1382F1383", "C1384F1385", "C1386F1387", "C1388F1389", "C1390F1391", "C1392F1393", "C1394F1395", "C1396F1397", "C1398F1399", "C1400F1401", "C1402F1403", "C1402F1403", "C3506F3510", "C3511F3515", "C3516F3520", "C3521F3525", "C3526F3530", "C3531F3535", "C3536F3540", "C3541F3545", "C3546F3550", "C3551F3555", "C3556F3560", "C3561F3565", "C3566F3570", "C3571F3575", "C3576F3580", "C3581F3585", "C3586F3590", "C3591F3595", "C3596F3600", "C3601F3605", "C3606F3610", "C3611F3615", "C3616F3620", "C3621F3625", "C3626F3630", "C3631F3635", "C3636F3640", "C3641F3645", "C3646F3650", "C3651F3655", "C3656F3660", "C3661F3665", "C3666F3670", "C3671F3675", "C3676F3680", "C3681F3685", "C3686F3690", "C3691F3695", "C3696F3700", "C3701F3705", "C3706F3710", "C3711F3715", "C3716F3720", "C3721F3725", "C3726F3730", "C3731F3735", "C3736F3740", "C3741F3745", "C3746F3750", "C3751F3755", "C3756F3760", "C3761F3765", "C3766F3770", "C3771F3775", "C3776F3780", "C3781F3785", "C3786F3790", "C3791F3795", "C3796F3800", "C3801F3805", "C3806F3810", "C3811F3815", "C3816F3820", "C3821F3825", "C3826F3830", "C3831F3835", "C3836F3840", "C3841F3845", "C3846F3850", "C3851F3855", "C3856F3860", "C3861F3865", "C3866F3870", "C3871F3875", "C3876F3880", "C3881F3885", "C3886F3890", "C3891F3895", "C3896F3900", "C3901F3905", "C3906F3910", "C3911F3915", "C3916F3920", "C3921F3925", "C3926F3930", "C3931F3935", "C3936F3940", "C3941F3945", "C3946F3950", "C3951F3955", "C3956F3960", "C3961F3965", "C3966F3970", "C3971F3975", "C3976F3980", "C3981F3985", "C3986F3990", "C3991F3995", "C3996F4000", "C3996F4000", "C3204F3204", "C3208F3208", "C3212F3212", "C3216F3216", "C3220F3220", "C3224F3224", "C3228F3228", "C3232F3232", "C3236F3236", "C3240F3240", "C3244F3244", "C3248F3248", "C3252F3252", "C3256F3256", "C3260F3260", "C3264F3264", "C3268F3268", "C3272F3272", "C3276F3276", "C3280F3280", "C3284F3284", "C3288F3288", "C3292F3292", "C3296F3296", "C3300F3300", "C3304F3304", "C3308F3308", "C3312F3312", "C3316F3316", "C3320F3320", "C3324F3324", "C3328F3328", "C3332F3332", "C3336F3336", "C3340F3340", "C3344F3344", "C3348F3348", "C3352F3352", "C3356F3356", "C3360F3360", "C3364F3364", "C3368F3368", "C3372F3372", "C3376F3376", "C3380F3380", "C3384F3384", "C3388F3388", "C3392F3392", "C3396F3396", "C3400F3400", "C3404F3404", "C3408F3408", "C3412F3412", "C3416F3416", "C3420F3420", "C3424F3424", "C3428F3428", "C3432F3432", "C3436F3436", "C3440F3440", "C3444F3444", "C3448F3448", "C3452F3452", "C3456F3456", "C3460F3460", "C3464F3464", "C3468F3468", "C3472F3472", "C3476F3476", "C3480F3480", "C3484F3484", "C3488F3488", "C3492F3492", "C3496F3496", "C3500F3500", "C3504F3504", "C3508F3508", "C3512F3512", "C3516F3516", "C3520F3520", "C3524F3524", "C3528F3528", "C3532F3532", "C3536F3536", "C3540F3540", "C3544F3544", "C3548F3548", "C3552F3552", "C3556F3556", "C3560F3560", "C3564F3564", "C3568F3568", "C3572F3572", "C3576F3576", "C3580F3580", "C3584F3584", "C3588F3588", "C3592F3592", "C3596F3596", "C3596F3596", "C1807F1805", "C1809F1807", "C1811F1809", "C1813F1811", "C1815F1813", "C1817F1815", "C1819F1817", "C1821F1819", "C1823F1821", "C1825F1823", "C1827F1825", "C1829F1827", "C1831F1829", "C1833F1831", "C1835F1833", "C1837F1835", "C1839F1837", "C1841F1839", "C1843F1841", "C1845F1843", "C1847F1845", "C1849F1847", "C1851F1849", "C1853F1851", "C1855F1853", "C1857F1855", "C1859F1857", "C1861F1859", "C1863F1861", "C1865F1863", "C1867F1865", "C1869F1867", "C1871F1869", "C1873F1871", "C1875F1873", "C1877F1875", "C1879F1877", "C1881F1879", "C1883F1881", "C1885F1883", "C1887F1885", "C1889F1887", "C1891F1889", "C1893F1891", "C1895F1893", "C1897F1895", "C1899F1897", "C1901F1899", "C1903F1901", "C1905F1903", "C1907F1905", "C1909F1907", "C1911F1909", "C1913F1911", "C1915F1913", "C1917F1915", "C1919F1917", "C1921F1919", "C1923F1921", "C1925F1923", "C1927F1925", "C1929F1927", "C1931F1929", "C1933F1931", "C1935F1933", "C1937F1935", "C1939F1937", "C1941F1939", "C1943F1941", "C1945F1943", "C1947F1945", "C1949F1947", "C1951F1949", "C1953F1951", "C1955F1953", "C1957F1955", "C1959F1957", "C1961F1959", "C1963F1961", "C1965F1963", "C1967F1965", "C1969F1967", "C1971F1969", "C1973F1971", "C1975F1973", "C1977F1975", "C1979F1977", "C1981F1979", "C1983F1981", "C1985F1983", "C1987F1985", "C1989F1987", "C1991F1989", "C1993F1991", "C1995F1993", "C1997F1995", "C1999F1997", "C2001F1999" };
        
        #region Import da API Kernel do Windows e das Variaveis que receberão Informações do HardDisk da Máquina (S/N)
        //importa a API Kernel32 do windows
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        extern static bool GetVolumeInformation(
        string RootPathName,
        StringBuilder VolumeNameBuffer,
        int VolumeNameSize,
        out uint VolumeSerialNumber,
        out uint MaximumComponentLength,
        out uint FileSystemFlags,
        StringBuilder FileSystemNameBuffer,
        int nFileSystemNameSize);
        #endregion

        #region Voltar SubChave e Chave para Ativação
        /// <summary>
        /// Retorna um DataTable com dois valores - Primeiro a SubChave que será perguntada ao usuário.
        /// Segundo, a Chave propriamente dita, que é a qual o usuário irá digitar e será comparada. O metodo
        /// recebe o numero do HD de 5 digitos gerado pelo Host e Retorna a Sub Chave que o Usuario
        /// Precisará digitar na terceira casa que é gerada dinamicamente.
        /// </summary>
        /// <param name="SubChave">Sub chave (Exemplo: 234 - Até 999)</param>
        /// <param name="chaveHD">Chave do HD da máquina que é gerada dinamicamente</param>
        /// <returns>Retorna DataTable com a SubChave e sua respectiva Chave</returns>
        public DataTable voltarCodigoeChaveAtivacao(string cnpjEmpresaUtilizadora)
        {
            Random number = new Random();
            int retorno = number.Next(999);

            DataTable dt_Chave = new DataTable();
            dt_Chave.Columns.Add("SubChave");
            dt_Chave.Columns.Add("Chave");
            dt_Chave.Columns.Add("SubHd");
            dt_Chave.Columns.Add("ChaveHD");
            dt_Chave.Columns.Add("CN");
            
            DataRow DR = dt_Chave.NewRow();
            DR["SubChave"] = retorno.ToString();
            DR["Chave"] = arrayChaves[retorno].ToString();
            DR["SubHd"] = retornaNumeroSerieHD();
            DR["ChaveHD"] = obterQuintaChave(retornaNumeroSerieHD());
            DR["CN"] = obterSextaChave(cnpjEmpresaUtilizadora);
            dt_Chave.Rows.Add(DR);
            return dt_Chave;
        }
        #endregion        
        
        #region Verifica se a Chave do Sistema é Válida
        /// <summary>
        /// Verifica se a chave usada pelo sistema (Standart, O.S, Basic, NFP, Restaurante é válida).
        /// Recebe a Chave Criptografada e verifica se realmente ela é válida e funcional.
        /// </summary>
        /// <param name="chave">Chave que está no banco de dados (descriptografada!)</param>
        /// <returns>Retorna True se for uma chave válida, false se não</returns>
        public bool verificaSeChaveSistemaEValida(string chave)
        {
            bool retorno = false;
            
            if(chave == "Ativ.Autom")
            {
                return true;
            }

            int indiceContador = 0;
            while (indiceContador < 999)
            {
                if(chave == arrayChaves[indiceContador].ToString())
                {
                    retorno = true;
                }
                indiceContador++;
            }
            return retorno;
        }
        #endregion    

        #region Retorna numero Serie HD
        /// <summary>
        /// Volta os 5 primeiros Digitos do Numero de Serie do HD
        /// </summary>
        /// <returns>Retorna numero Série HD - 5 Digitos</returns>
        public string retornaNumeroSerieHD()
        {
            StringBuilder volname = new StringBuilder(256);
            StringBuilder fsname = new StringBuilder(256);
            uint sernum, maxlen, flags;
            if (!GetVolumeInformation("c:\\", volname, volname.Capacity, out sernum, out maxlen, out flags, fsname, fsname.Capacity))
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            string volnamestr = volname.ToString();
            string fsnamestr = fsname.ToString();

            string numeroSerieHDMaquina = Convert.ToString(sernum);
            return numeroSerieHDMaquina.Substring(0,5);
        }
        #endregion

        #region Obter Quinta Chave Dinamica
        /// <summary>
        /// Retorna a Quinta Chave do HD criptografada para letras
        /// </summary>
        /// <param name="serialHD">5 digitos da quinta chave em numeros</param>
        /// <returns>Retorna As letras da Chave</returns>
        public string obterQuintaChave(string chaveHD)
        {
            string serialHD = chaveHD;
            string quatroPrimeirosDigitosHD = serialHD.Substring(0, 5).ToString();

            //pega separadamente os 4 primeiros digitos do HD que serão usados na chave
            int priDigito = Convert.ToInt32(quatroPrimeirosDigitosHD.Substring(0, 1).ToString());
            int segDigito = Convert.ToInt32(quatroPrimeirosDigitosHD.Substring(1, 1).ToString());
            int terDigito = Convert.ToInt32(quatroPrimeirosDigitosHD.Substring(2, 1).ToString());
            int quaDigito = Convert.ToInt32(quatroPrimeirosDigitosHD.Substring(3, 1).ToString());
            int quiDigito = Convert.ToInt32(quatroPrimeirosDigitosHD.Substring(4, 1).ToString());

            string priLetra = "";
            string segLetra = "";
            string terLetra = "";
            string quaLetra = "";
            string quiLetra = "";

            if (priDigito == 0)
            {
                priLetra = "A";
            }

            if (priDigito == 1)
            {
                priLetra = "A";
            }

            if (priDigito == 2)
            {
                priLetra = "C";
            }

            if (priDigito == 3)
            {
                priLetra = "F";
            }

            if (priDigito == 4)
            {
                priLetra = "H";
            }

            if (priDigito == 5)
            {
                priLetra = "Y";
            }

            if (priDigito == 6)
            {
                priLetra = "Z";
            }

            if (priDigito == 7)
            {
                priLetra = "A";
            }

            if (priDigito == 8)
            {
                priLetra = "U";
            }

            if (priDigito == 9)
            {
                priLetra = "T";
            }

            if (segDigito == 0)
            {
                segLetra = "D";
            }

            if (segDigito == 1)
            {
                segLetra = "D";
            }

            if (segDigito == 2)
            {
                segLetra = "R";
            }

            if (segDigito == 3)
            {
                segLetra = "Y";
            }

            if (segDigito == 4)
            {
                segLetra = "U";
            }

            if (segDigito == 5)
            {
                segLetra = "K";
            }

            if (segDigito == 6)
            {
                segLetra = "W";
            }

            if (segDigito == 7)
            {
                segLetra = "O";
            }

            if (segDigito == 8)
            {
                segLetra = "N";
            }

            if (segDigito == 9)
            {
                segLetra = "V";
            }

            if (terDigito == 0)
            {
                terLetra = "J";
            }

            if (terDigito == 1)
            {
                terLetra = "J";
            }

            if (terDigito == 2)
            {
                terLetra = "P";
            }

            if (terDigito == 3)
            {
                terLetra = "Y";
            }

            if (terDigito == 4)
            {
                terLetra = "X";
            }

            if (terDigito == 5)
            {
                terLetra = "E";
            }

            if (terDigito == 6)
            {
                terLetra = "M";
            }

            if (terDigito == 7)
            {
                terLetra = "T";
            }

            if (terDigito == 8)
            {
                terLetra = "T";
            }

            if (terDigito == 9)
            {
                terLetra = "C";
            }

            if (quaDigito == 0)
            {
                quaLetra = "V";
            }

            if (quaDigito == 1)
            {
                quaLetra = "V";
            }

            if (quaDigito == 2)
            {
                quaLetra = "G";
            }

            if (quaDigito == 3)
            {
                quaLetra = "F";
            }

            if (quaDigito == 4)
            {
                quaLetra = "F";
            }

            if (quaDigito == 5)
            {
                quaLetra = "L";
            }

            if (quaDigito == 6)
            {
                quaLetra = "I";
            }

            if (quaDigito == 7)
            {
                quaLetra = "O";
            }

            if (quaDigito == 8)
            {
                quaLetra = "S";
            }

            if (quaDigito == 9)
            {
                quaLetra = "A";
            }

            if (quiDigito == 0)
            {
                quiLetra = "B";
            }

            if (quiDigito == 1)
            {
                quiLetra = "C";
            }

            if (quiDigito == 2)
            {
                quiLetra = "D";
            }

            if (quiDigito == 3)
            {
                quiLetra = "E";
            }

            if (quiDigito == 4)
            {
                quiLetra = "F";
            }

            if (quiDigito == 5)
            {
                quiLetra = "G";
            }

            if (quiDigito == 6)
            {
                quiLetra = "H";
            }

            if (quiDigito == 7)
            {
                quiLetra = "I";
            }

            if (quiDigito == 8)
            {
                quiLetra = "J";
            }

            if (quiDigito == 9)
            {
                quiLetra = "L";
            }

            
            string chaveFinal = priLetra + segLetra + terLetra + quaLetra + quiLetra;
            return chaveFinal;
        }
        #endregion

        #region Obter Sexta Chave Dinamica
        /// <summary>
        /// Retorna a Sexta CHAVE sem pontuação
        /// </summary>
        /// <param name="CN">CN sem pontuação</param>
        /// <returns>Retorna As letras da Chave</returns>
        public string obterSextaChave(string CN)
        {

            if(CN == "" || CN == null)
            {
                CN = "09488916000107";
            }

            string serialCN = CN;

            int contadorLenght = CN.Length;
                        
            int priDig = 0;
            int segDig = 0;
            int terDig = 0;
            int quaDig = 0;
            int quiDig = 0;
            int sexDig = 0;
            int setDig = 0;
            int oitDig = 0;
            int nonDig = 0;
            int decDig = 0;
            int decPDig = 4;
            int decSDig = 3;
            int decTDig = 2;
            int decQDig = 1;

            string priDigStr = "";
            string segDigStr = "";
            string terDigStr = "";
            string quaDigStr = "";
            string quiDigStr = "";
            string sexDigStr = "";
            string setDigStr = "";
            string oitDigStr = "";
            string nonDigStr = "";
            string decDigStr = "";
            string decPDigStr = "";
            string decSDigStr = "";
            string decTDigStr = "";
            string decQDigStr = "";
                                    
            priDig = Convert.ToInt32(serialCN.Substring(0, 1).ToString());
            segDig = Convert.ToInt32(serialCN.Substring(1, 1).ToString());
            terDig = Convert.ToInt32(serialCN.Substring(2, 1).ToString());
            quaDig = Convert.ToInt32(serialCN.Substring(3, 1).ToString());
            quiDig = Convert.ToInt32(serialCN.Substring(4, 1).ToString());

            sexDig = Convert.ToInt32(serialCN.Substring(5, 1).ToString());
            setDig = Convert.ToInt32(serialCN.Substring(6, 1).ToString());
            oitDig = Convert.ToInt32(serialCN.Substring(7, 1).ToString());
            nonDig = Convert.ToInt32(serialCN.Substring(8, 1).ToString());
            decDig = Convert.ToInt32(serialCN.Substring(9, 1).ToString());
            decPDig = Convert.ToInt32(serialCN.Substring(10, 1).ToString());

            if(contadorLenght >= 12)
            {
                decSDig = Convert.ToInt32(serialCN.Substring(11, 1).ToString());
                decTDig = Convert.ToInt32(serialCN.Substring(12, 1).ToString());
                decQDig = Convert.ToInt32(serialCN.Substring(13, 1).ToString());
            }

            priDigStr = metodoAuxiliarDoSextoPraGerarCN(priDig);
            segDigStr = metodoAuxiliarDoSextoPraGerarCN(segDig);
            terDigStr = metodoAuxiliarDoSextoPraGerarCN(terDig);
            quaDigStr = metodoAuxiliarDoSextoPraGerarCN(quaDig);
            quiDigStr = metodoAuxiliarDoSextoPraGerarCN(quiDig);
            sexDigStr = metodoAuxiliarDoSextoPraGerarCN(sexDig);
            setDigStr = metodoAuxiliarDoSextoPraGerarCN(setDig);
            oitDigStr = metodoAuxiliarDoSextoPraGerarCN(oitDig);
            nonDigStr = metodoAuxiliarDoSextoPraGerarCN(nonDig);
            decDigStr = metodoAuxiliarDoSextoPraGerarCN(decDig);
            decPDigStr = metodoAuxiliarDoSextoPraGerarCN(decPDig);
            decSDigStr = metodoAuxiliarDoSextoPraGerarCN(decSDig);
            decTDigStr = metodoAuxiliarDoSextoPraGerarCN(decTDig);
            decQDigStr = metodoAuxiliarDoSextoPraGerarCN(decQDig);




            string chaveFinal = priDigStr + segDigStr + terDigStr + quaDigStr + quiDigStr + sexDigStr + setDigStr + oitDigStr + nonDigStr + decDigStr + decPDigStr + decSDigStr + decTDigStr + decQDigStr;
            return chaveFinal;
        }
        #endregion

        #region Metodo Auxiliar Do Sexto Método pra Gerar Chave Baseado no CN
        public string metodoAuxiliarDoSextoPraGerarCN(int digCN)
        {

            if(digCN == 0)
            {
                return "A";
            }

            if (digCN == 1)
            {
                return "C";
            }

            if (digCN == 2)
            {
                return "E";
            }

            if (digCN == 3)
            {
                return "F";
            }

            if (digCN == 4)
            {
                return "H";
            }

            if (digCN == 5)
            {
                return "J";
            }

            if (digCN == 6)
            {
                return "M";
            }

            if (digCN == 7)
            {
                return "O";
            }

            if (digCN == 8)
            {
                return "Y";
            }

            if (digCN == 9)
            {
                return "W";
            }
            return "";
        }
        #endregion

        #region validaQuartoCampo
        /// <summary>
        /// Valida o quarto campo do numero serial. No quarto campo vão as informações sobre a quantidade
        /// de hosts autorizados para usar o sistema e também sobre a quantidade de tempo até a próxima
        /// ativação. Use esse método apenas para validar o campo - Ativação no método ativarSoftware()
        /// </summary>
        /// <param name="campo">Campo que será validado (5 digitos)</param>
        /// <returns>retorna true se estiver correto, false se não</returns>
        public bool validaQuartoCampo(string campo)
        {
            NewContasMatematicas contas = new NewContasMatematicas();
            if (contas.verificaSeEInteiro(campo) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion        
    }//fim classe
}//fim namespace