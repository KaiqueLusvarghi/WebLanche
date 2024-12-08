using WebLanches.Context;
using WebLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WebLanches.Areas.Admin.Services
{
    public class GraficoVendasServices
    {
        private readonly AppDbContext context;

        public GraficoVendasServices(AppDbContext context)
        {
            this.context = context;
        }

        public List<LancheGrafico> GetVendasLanche(int dias = 360) 
        {
            var data = DateTime.Now.AddDays(-dias);

            var lanches = (from pd in context.PedidosDetalhes
                           join l in context.Lanches on pd.LancheId equals l.LancheId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new { pd.LancheId, l.Nome }
                           into g
                           select new
                           {
                               LancheNome = g.Key.Nome,
                               LanchesQuantidade = g.Sum(q => q.Quantidade),
                               LanchesValorTotal = g.Sum(a => a.Preco * a.Quantidade)
                           });

            var list = new List<LancheGrafico>();
            foreach (var item in lanches) 
            {
                var lanche = new LancheGrafico();
                lanche.LancheNome = item.LancheNome;
                lanche.LanchesQuantidade = item.LanchesQuantidade;
                lanche.LanchesValorTotal = item.LanchesValorTotal;
                list.Add(lanche);
            }

            return list;
        }
    }
}
