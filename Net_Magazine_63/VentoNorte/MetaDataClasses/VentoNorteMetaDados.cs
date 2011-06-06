using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace VentoNorte
{
    [ScaffoldTable(false)]
    public partial class Grupos { }
    
    [MetadataType(typeof(ProdutosMetaDados))]
    public partial class Produtos { }

    [TableName("Cadastro de Produtos")]
    public class ProdutosMetaDados
    {
        [DisplayName("Nome")]
        public object ProdName { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.00}")]
        [DisplayName("Preço")]
        public object ProdPreco { get; set; }

        [ScaffoldColumn(false)]
        public object ProdEstoque { get; set; }
    }

    [MetadataType(typeof(FornecedoresMetaDados))]
    public partial class Fornecedores { }

    [TableName("Cadastro de Fornecedores")]
    [DisplayColumn("FornNome")]
    public class FornecedoresMetaDados {}

}