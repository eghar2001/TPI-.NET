var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/producto/{id}", async (int id) =>
{
    Negocio.Producto negocio_producto = new Negocio.Producto();
    if (negocio_producto.get_one(id) == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(negocio_producto.get_one(id));
    }
});

app.MapGet("/productos", async () =>
{
    Negocio.Producto negocio_producto = new Negocio.Producto();
    return Results.Ok(negocio_producto.find_all());
});

app.MapPost("/productos", async (Entidades.Producto producto) =>
{
    Negocio.Producto negocio_producto = new Negocio.Producto();
    negocio_producto.agregar_producto(producto);
});

app.MapPut("/productos/{id}", async (Entidades.Producto producto, int id) =>
{
    Negocio.Producto negocio_producto = new Negocio.Producto();
    Entidades.Producto producto_original = negocio_producto.get_one(id);
    if (producto_original == null)
    {
        Results.NotFound();
    }
    else
    {
        producto.Id = producto_original.Id;

        negocio_producto.modificar_producto(producto);
    }

});

app.MapDelete("/productos/{id}", async (int id) =>
{
    Negocio.Producto negocio_producto = new Negocio.Producto();
    Entidades.Producto producto = negocio_producto.get_one(id);
    if (producto == null)
    {
        Results.NotFound();
    }
    else
    {
        negocio_producto.borrar_producto(producto);
    }
});

app.Run();