//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class QRCode_Template
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QRCode_Template()
        {
            this.Account_QRCode_Template = new HashSet<Account_QRCode_Template>();
        }
    
        public System.Guid TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string ExampleUrl { get; set; }
        public string TemplatePSDUrl { get; set; }
        public string NickName_FontFamily { get; set; }
        public Nullable<int> NickName_FontSize { get; set; }
        public string NickName_FontColor { get; set; }
        public Nullable<int> NickName_FontX { get; set; }
        public Nullable<int> NickName_FontY { get; set; }
        public Nullable<int> HeadImg_X { get; set; }
        public Nullable<int> HeadImg_Y { get; set; }
        public Nullable<int> HeadImg_Width { get; set; }
        public Nullable<int> HeadImg_Height { get; set; }
        public Nullable<int> QRCode_X { get; set; }
        public Nullable<int> QRCode_Y { get; set; }
        public Nullable<int> QRCode_Width { get; set; }
        public Nullable<int> QRCode_Height { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account_QRCode_Template> Account_QRCode_Template { get; set; }
    }
}
