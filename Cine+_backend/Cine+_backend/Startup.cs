using Cine__backend.Repositories;
using Cine__backend.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using Microsoft.AspNetCore.Http;
using Cine__backend.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Cine__backend.Settings;
using Cine__backend.Context;

namespace Cine__backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Configuration from AppSettings
            services.Configure<JWT>(Configuration.GetSection("JWT"));

            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(Configuration["Data:Cine:ConnectionString"]));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            services.AddScoped<IRoomRepository,RoomRepository>();
            services.AddScoped<IClubMemberRepository, ClubMemberRepository>();

            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IUserFilmRepository, UserFilmRepository>();
            services.AddScoped<IFilmScreeningRepository, FilmScreeningRepository>();
            services.AddScoped<IFilmScreeningPriceModificationRepository, FilmScreeningPriceModificationRepository>();
            services.AddScoped<IPriceModificationRepository, PriceModificationRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();            
            services.AddScoped<IFilmRolRepository, FilmRolRepository>();
            services.AddScoped<IBookEntryRepository, BookEntryRepository>();
            services.AddScoped<ISeatSectionLevelRoomRepository, SeatSectionLevelRoomRepository>();
            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            services.AddScoped<ITop10Repository, Top10Repository>();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.
                        AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                    });
            });
            services.AddIdentity<User, IdentityRole>().
                AddEntityFrameworkStores<AppDbContext>();
            // For Identity  
            //services.AddIdentity<User, IdentityRole>()
            //        .AddEntityFrameworkStores<AppDbContext>()
            //        .AddDefaultTokenProviders();

            //Adding Athentication - JWT
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]))
                    };
                });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cine__backend", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cine__backend v1"));
            }

            app.UseCors();

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
                RequestPath = new PathString("/Resources")
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
