using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CozaStore.Models;

namespace CozaStore.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cor> Cores { get; set; }
    public DbSet<ListaDesejo> ListaDesejos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoAvalicao> ProdutoAvalicaos { get; set; }
    public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; }
    public DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }
    public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
    public DbSet<ProdutoTag> ProdutoTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Tamanho> Tamanhos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Chave Primária Composta - ProdutoFoto
        builder.Entity<ProdutoFoto>().HasKey(
            pf => new { pf.Id, pf.ProdutoId }
        );
        #endregion

        #region Relacionamento para muitos para muitos - ProdutoAvaliacao
        builder.Entity<ProdutoAvalicao>().HasKey(
            pa => new { pa.ProdutoId, pa.UsuarioId }
        );

        builder.Entity<ProdutoAvalicao>()
            .HasOne(pa => pa.Produto)
            .WithMany(p => p.Avalicoes)
            .HasForeignKey(pa => pa.ProdutoId);

        builder.Entity<ProdutoAvalicao>()
            .HasOne(pa => pa.Usuario)
            .WithMany(u => u.Avalicoes)
            .HasForeignKey(pa => pa.UsuarioId);

        #endregion

        #region Relacionamento Muitos para muitos - ProdutoCategoria
        builder.Entity<ProdutoCategoria>().HasKey(
            pc => new { pc.ProdutoId, pc.CategoriaId }
        );

        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Produto)
            .WithMany(p => p.Categorias)
            .HasForeignKey(pc => pc.ProdutoId);

        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Categoria)
            .WithMany(u => u.Produtos)
            .HasForeignKey(pc => pc.CategoriaId);
        #endregion

        #region Relacionamento Muitos para muitos - ProdutoTag
        builder.Entity<ProdutoTag>().HasKey(
            pt => new { pt.ProdutoId, pt.TagId }
   );

        builder.Entity<ProdutoTag>()
            .HasOne(pt => pt.Produto)
            .WithMany(p => p.Tags)
            .HasForeignKey(pt => pt.ProdutoId);

        builder.Entity<ProdutoTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.Produtos)
            .HasForeignKey(pt => pt.TagId);
        #endregion

        #region Relacionamento Muitos para muitos - ProdutoEstoque

        builder.Entity<ProdutoEstoque>()
            .HasOne(pe => pe.Produto)
            .WithMany(p => p.Estoques)
            .HasForeignKey(pe => pe.ProdutoId);

        builder.Entity<ProdutoEstoque>()
            .HasOne(pe => pe.Cor)
            .WithMany(c => c.Estoques)
            .HasForeignKey(pe => pe.CorId);

        builder.Entity<ProdutoEstoque>()
           .HasOne(pe => pe.Tamanho)
           .WithMany(t => t.Estoques)
           .HasForeignKey(pe => pe.TamanhoId);
        #endregion

        #region Relacionamento Muito para Muitos - CarrinhoProduto
        builder.Entity<CarrinhoProduto>().HasKey(
            cp => new { cp.CarrinhoId, cp.ProdutoEstoqueId }
        );

        builder.Entity<CarrinhoProduto>()
             .HasOne(cp => cp.Carrinho)
             .WithMany(c => c.Produtos)
             .HasForeignKey(cp => cp.CarrinhoId);

        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.ProdutoEstoque)
            .WithMany(pe => pe.Carrinhos)
            .HasForeignKey(cp => cp.ProdutoEstoqueId);
        #endregion

        #region Relacionamento Muitos para Muitos - ListaDesejo
        builder.Entity<ListaDesejo>().HasKey(
            ld => new { ld.ProdutoId, ld.UsuarioId }
        );
        builder.Entity<ListaDesejo>()
            .HasOne(ld => ld.Produto)
            .WithMany(p => p.ListaDesejos)
            .HasForeignKey(ld => ld.ProdutoId);
        builder.Entity<ListaDesejo>()
            .HasOne(ld => ld.Usuario)
            .WithMany(u => u.ListaDesejos)
            .HasForeignKey(ld => ld.UsuarioId);
        #endregion
    }


}
