// Sistema de facturación con control antifraude

Console.WriteLine("sistema de factorizacion");
Console.WriteLine("tipo de cliente");
Console.WriteLine("1 Estudiante");
Console.WriteLine("2 docente");
Console.WriteLine("3 administrativo");
Console.WriteLine("4 externo");
int tipoCliente = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrse monto base");
double montoBase = double .Parse(Console.ReadLine());
Console.WriteLine("metodo de pago");
Console.WriteLine("1 EFECTIVO");
Console.WriteLine("2 targeta");
Console.WriteLine("3 referencia");
Console.WriteLine("4 externo");
int tipoClinte=int.Parse(Console.ReadLine());
Console.WriteLine("ingrese monto base");
montoBase = double .Parse(Console.ReadLine());
Console.WriteLine("metodo de pago");
Console.WriteLine("1 Efectico");
Console.WriteLine("2 targeta");
Console.WriteLine("3 transferencia");
int metodoPago = int.Parse(Console.ReadLine());
int.Parse(Console.ReadLine());
Console.WriteLine("tiene cupon si / no");
int tieneCupon = int.Parse(Console.ReadLine().ToUpper();
if (tieneCupon = "Si");
{
	Console.WriteLine("ingrese codigo");
	int codigoCupon = int.Parse(Console.ReadLine().ToUpper();
	if (codigoCupon.StartsWith("U"))
	{
		char ultimo = codigoCupon[codigoCupon.Lenght 1];
		if (char.IsDigit(ultimo))
		{
			int numero = int.Parse(ultimo.ToString());
			if (numero % 2 == 0)
			{
				 cuponValido = true;
			}
		}
	}
}
Console.WriteLine("1 ninguno");
Console.WriteLine("2 cupon invalido repetido");
Console.WriteLine("3 pagos rechazados multiples");
tipoFraude = int.Parse(Console.ReadLine());
switch (tipoCliente)
{
	case 1:
		if (metodoPago == 1)
			descuento = montoBase * 0.10;
		else if (metodoPago == 2)
			descuento = montoBase * 0.07;
		else
			descuento = montoBase * 0.05;
		break;
	case 2:
		descuento = montoBase * 0.12;
		break;
	case 3:
		descuento = montoBase * 0.08;
		break;
	case 4:
		descuento = 0;
		break;
	default:
		Console.WriteLine("tipo de cliente invalido");
		return;
}
if (cuponValido)
{
	descuento += montoBase * 0.05;
}
if (tipoFraude == 2)
{
	recargo = montoBase * 0.10;
}
else
{
	if (tipoFraude == 3)
	{
		recargo = montoBase * 0.15;
	}
}
descuento = 0;
}
double totalFinal = montoBase - descuento + recargo;
}















