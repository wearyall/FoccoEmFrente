import React from "react";

function Uppercase(props){
   const texto = props.texto.toUpperCase();
   return <p>HOME</p>
}

export default function Home() {
   return (
      <div>
         <h1>Meu Componente</h1>
         <Uppercase/>
      </div>
   );
}
