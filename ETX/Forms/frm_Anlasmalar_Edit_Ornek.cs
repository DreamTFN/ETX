using System;

namespace ETX.Forms
{

    public partial class frm_Anlasmalar_Edit_Ornek : DevExpress.XtraEditors.XtraForm
    {
        public frm_Anlasmalar_Edit_Ornek()
        {
            InitializeComponent();
            Set_Formul_Text();
        }

        private void Set_Formul_Text()
        {

            String formul = @"
            Formül Nasıl Yazılmalı :
            (Parametre ve Koşul, Doğruysa, Yanlışsa) bu örnekte eğer koşul ile bir parametre sınanmaktadır. 
            Parametre ve Koşul alanına girilen değer doğru ise formülün koşuldan sonraki ilk sonucu (Doğruysa sonucu), değilse ikinci sonuç (Yanlış sonucu) çalıştırılır.
            
            Parametreler : 
            FA = Fiziksel Alan (Fiziksel alan parametresi, fiziksel alan kodu formüle eklenmelidir)
            KS = Kayılımcı Sayısı
            
            Koşullar :
            >   - büyüktür
            <   - küçüktür
            >=  - büyük eşit
            <=  - küçük eşit
            ==  - eşit
            !=  - eşit değil

            Örnek Formüller :
            1- (KS > 200, 10, 5)                             Açıklama : KS (Katılımcı sayısı parametresi) 200 den büyükse sonuca 10 yaz değilse 5 yaz
            2- (FA == 'A001', 40, 10)                        Açıklama : FA (Fiziksel alan parametresi) A001 kodlu fizikel alana eşit ise sonuca 40 yaz değilse 10 yaz
            3- (FA == 'A001', IF (KS > 500, 50, 40), 0)      Açıklama : İç içe koşullar FA (Fiziksel alan), A001 kodlu fizikel alana eşit ise ve KS (Katılımcı sayısı) 500 den büyükse 50, 500 den büyük değilse 40 yaz, FA (Fiziksel alan) A001 e eşit değilse 0 yaz  

            ";


            formula_memoEdit.Text = formul;


        }

    }
}