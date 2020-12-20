using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ZZT.ABP.EntityFrameworkCore
{
    public static class ABPDbContextModelCreatingExtensions
    {
        public static void ConfigureABP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ABPConsts.DbTablePrefix + "YourEntities", ABPConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Book>(b =>
            {
                b.ToTable(ABPConsts.DbTablePrefix + "Book", ABPConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

        }
    }
}