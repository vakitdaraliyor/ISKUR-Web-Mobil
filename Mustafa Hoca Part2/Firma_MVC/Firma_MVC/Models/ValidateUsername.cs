using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Firma_MVC.Models
{
    public class ValidateUsername : ValidationAttribute
    {
        FIRMAMODEL db = new FIRMAMODEL();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int sonuc = (validationContext.ObjectInstance as KULLANICI).KULLANICI_REFNO;

                string kullanıcıAdı = value.ToString();
                KULLANICI k = db.KULLANICIs.Where(k1 => k1.KULLANICI_ADI == kullanıcıAdı && k1.KULLANICI_REFNO!=sonuc).FirstOrDefault();
                    
                if (k == null)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Kullanıcı adı zaten var");
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " Giriniz");
            }
        }
    }
}