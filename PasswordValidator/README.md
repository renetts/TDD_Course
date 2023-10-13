Validar Contraseña

Crear una aplicación que pueda validar las contraseñas para una forma de registro. La validación toma como entrada un string y regresa el resultado de la validación. El resultado de la validación debe de contener un valor boolean indicando si el password es válido o no, y además un campo con el posible error si es que no es válida la contraseña.

Criterios de Aceptación

1. La contraseña debe contener al menos 8 caracteres de longitud. En caso de no cumplir, deberá regresar el siguiente mensaje: "La contraseña debe de ser de al menos de 8 caracteres de longitud."

2. La contraseña al menos debe tener 2 números. En caso de no cumplir, deberá regresar el siguiente mensaje: "La contraseña debe contener al menos dos números.".

3. La validación deberá validar múltiples errores.

Por ejemplo, "mypass" tendrá el siguiente mensaje de error: 
"La contraseña debe tener al menos 8 caracteres de longitud
La contraseña debe contener al menos dos números"

4. La contraseña debe contener al menos una letra mayúscula. En caso de no cumplir, entonces deberá regresar el siguiente mensaje: "la contraseña debe contener al menos una letra mayúscula".

5. La contraseña debe contener al menos un caracter especial (!@#$%&). En caso de no cumplir entonces deberá regresar el siguiente mensaje: "la contraseña debe contener al menos un caracter especial"