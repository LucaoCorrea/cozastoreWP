using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CozaStore.Models;

namespace CozaStore.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Cor
        List<Cor> cores = new() {
            new Cor() {
                Id = 1,
                Name = "Preto",
                CodigoHexa = "#222"
            },
            new Cor() {
                Id = 2,
                Name = "Azul",
                CodigoHexa = "#4272d7"
            },
            new Cor() {
                Id = 3,
                Name = "Cinza",
                CodigoHexa = "#b3b3b3"
            },
            new Cor() {
                Id = 4,
                Name = "Verde",
                CodigoHexa = "#00ad5f"
            },
            new Cor() {
                Id = 5,
                Name = "Vermelho",
                CodigoHexa = "#fa4251"
            },
            new Cor() {
                Id = 6,
                Name = "Branco",
                CodigoHexa = "#aaa"
            }
        };
        builder.Entity<Cor>().HasData(cores);
        #endregion

        #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Name = "Feminina",
                Foto = @"images/categorias/1.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Name = "Masculina",
                Foto = @"images/categorias/2.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Name = "Acessórios",
                Foto = @"images/categorias/3.jpg",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Name = "Bolsas",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 5,
                Name = "Calçados",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 6,
                Name = "Relógios",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Tag
        List<Tag> tags = new() {
            new Tag() {
                Id = 1,
                Name = "Fashion"
            },
            new Tag() {
                Id = 2,
                Name = "LifeStyle"
            },
            new Tag() {
                Id = 3,
                Name = "Denim"
            },
            new Tag() {
                Id = 4,
                Name = "StreetStyle"
            },new Tag() {
                Id = 5,
                Name = "Crafts"
            }
        };
        builder.Entity<Tag>().HasData(tags);
        #endregion

        #region Populate Tamanho
        List<Tamanho> tamanhos = new() {
            new Tamanho() {
                Id = 1,
                Sigla = "P",
                Name = "Pequeno"
            },
            new Tamanho() {
                Id = 2,
                Sigla = "M",
                Name = "Médio"
            },
            new Tamanho() {
                Id = 3,
                Sigla = "G",
                Name = "Grande"
            },
            new Tamanho() {
                Id = 4,
                Sigla = "GG",
                Name = "Extra Grande"
            }
        };
        builder.Entity<Tamanho>().HasData(tamanhos);
        #endregion

        #region Populate Produtos
        List<Produto> produtos = new() {
            new Produto() {
                Id = 1,
                Name = "Camiseta Esprit Ruffle",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 20.64M,
                PrecoDesconto = 20.64M,
                SKU = "CAM-01",
                Destaque = true
            },
            new Produto() {
                Id = 2,
                Name = "Camiseta Herschel supply",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 35.31M,
                PrecoDesconto = 35.31M,
                SKU = "CAM-02",
                Destaque = true
            },
            new Produto() {
                Id = 3,
                Name = "Camiseta Quadriculada",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 25.50M,
                PrecoDesconto = 25.50M,
                SKU = "CAM-03",
                Destaque = true
            },
            new Produto() {
                Id = 4,
                Name = "Casaco Classic Trench",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 75.25M,
                PrecoDesconto = 75.25M,
                SKU = "CAS-01",
                Destaque = true
            },
            new Produto() {
                Id = 5,
                Name = "Lightweight Jacket",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 53.0M,
                PrecoDesconto = 53.0M,
                SKU = "COJ-01",
                Destaque = true
            },
            new Produto() {
                Id = 6,
                Name = "Femme T-Shirt In Stripe",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 25.85M,
                PrecoDesconto = 25.85M,
                SKU = "CAM-06",
                Destaque = true
            },
            new Produto() {
                Id = 7,
                Name = "Camiseta Herschel supply",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 63.16M,
                PrecoDesconto = 63.16M,
                SKU = "CAM-09",
                Destaque = true
            },
            new Produto() {
                Id = 8,
                Name = "Camiseta T-Shirt with Sleeve",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 18.49M,
                PrecoDesconto = 18.49M,
                SKU = "CAM-14",
                Destaque = true
            },
            new Produto() {
                Id = 9,
                Name = "Relógio Vintage Classic",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 93.20M,
                PrecoDesconto = 93.20M,
                SKU = "REL-01",
                Destaque = true
            },
            new Produto() {
                Id = 10,
                Name = "Tênis All Star Hi Plimsolls",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 75.0M,
                PrecoDesconto = 75.0M,
                SKU = "CAL-09",
                Destaque = true
            },
            new Produto() {
                Id = 11,
                Name = "Cinto de Couro",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 63.15M,
                PrecoDesconto = 63.15M,
                SKU = "CIN-04",
                Destaque = true
            },
            new Produto() {
                Id = 12,
                Name = "Mini Silver Mesh Watch",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 86.85M,
                PrecoDesconto = 86.85M,
                SKU = "REL-04",
                Destaque = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoCategoria> produtoCategorias = new() {
            new ProdutoCategoria() {
                ProdutoId = 1,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 2,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 3,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 4,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 6
            },
            new ProdutoCategoria() {
                ProdutoId = 10,
                CategoriaId = 5
            },
            new ProdutoCategoria() {
                ProdutoId = 11,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 12,
                CategoriaId = 6
            }
        };
        builder.Entity<ProdutoCategoria>().HasData(produtoCategorias);

        List<ProdutoTag> produtoTags = new();
        for (int i = 1; i <= 12; i++)
            produtoTags.Add(new ProdutoTag()
            {
                ProdutoId = i,
                TagId = (byte)(new Random().Next(5) + 1)
            });
        builder.Entity<ProdutoTag>().HasData(produtoTags);

        List<ProdutoFoto> produtoFotos = new();
        for (int i = 1; i <= 12; i++)
            produtoFotos.Add(new ProdutoFoto()
            {
                Id = 1,
                ProdutoId = i,
                ArquivoFoto = $"/images/produtos/{i}/1.jpg",
                Destaque = true
            });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 2,
            ProdutoId = 5,
            ArquivoFoto = @"/images/produtos/5/2.jpg",
            Destaque = false
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 3,
            ProdutoId = 5,
            ArquivoFoto = $"/images/produtos/5/3.jpg",
            Destaque = false
        });
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);

        List<ProdutoEstoque> produtoEstoque = new();
        int id = 1;
        for (int p = 1; p <= 8; p++)
            for (byte c = 1; c <= 6; c++)
                for (byte t = 1; t <= 4; t++)
                {
                    produtoEstoque.Add(new ProdutoEstoque()
                    {
                        Id = id,
                        ProdutoId = p,
                        CorId = c,
                        TamanhoId = t,
                        QtdeEstoque = new Random().Next(50)
                    });
                    id += 1;
                }
        builder.Entity<ProdutoEstoque>().HasData(produtoEstoque);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Funcionário",
               NormalizedName = "FUNCIONARIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@cozastore.com",
                NormalizedEmail = "ADMIN@COZASTORE.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Name = "José Antonio Gallo Junior",
                DataNascimento = DateTime.Parse("05/08/1981"),
                Foto = "/images/usuarios/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}