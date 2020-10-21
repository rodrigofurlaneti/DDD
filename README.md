# DDD

<table style="width:100%">
  <tr>
    <th>Tecnologia</th>
    <th>Versão</th>
    <th>Camada</th>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>.NET Framework</td>
    <td VALIGN = Middle Align = Center>4.5</td>
    <td VALIGN = Middle Align = Center>Todas</td>
</tr>
  <tr>
    <td VALIGN = Middle Align = Center>Entity Framework</td>
    <td VALIGN = Middle Align = Center>6.1</td>
    <td VALIGN = Middle Align = Center>0 - Presentation e 4.1 - Infra.Data</td>
</tr>
  <tr>
    <td VALIGN = Middle Align = Center>System.Data.SqlClient</td>
    <td VALIGN = Middle Align = Center>4.1.1</td>
    <td VALIGN = Middle Align = Center>0 - Presentation e 4.1 - Infra.Data</td>
</tr>
  <tr>
    <td VALIGN = Middle Align = Center>AutoMapper</td>
    <td VALIGN = Middle Align = Center>3.2.1</td>
    <td VALIGN = Middle Align = Center>0 - Presentation</td>
</tr>
  
</table>


<table style="width:100%">
  <caption>Camadas</caption>
  <tr>
    <th>Ordem</th>
    <th>Nome</th>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>0</td>
    <td VALIGN = Middle Align = Center>Presentation</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>0</td>
    <td VALIGN = Middle Align = Center>DDD.MVC</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>1</td>
    <td VALIGN = Middle Align = Center>Services</td>
  </tr>
  
  <tr>
    <td VALIGN = Middle Align = Center>2</td>
    <td VALIGN = Middle Align = Center>Application</td>
  </tr>
      <tr>
    <td VALIGN = Middle Align = Center>2</td>
    <td VALIGN = Middle Align = Center>DDD.Application</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>3</td>
    <td VALIGN = Middle Align = Center>Domain</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>3</td>
    <td VALIGN = Middle Align = Center>DDD.Domain</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>4</td>
    <td VALIGN = Middle Align = Center>Infra</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>4.1</td>
    <td VALIGN = Middle Align = Center>Infra.CrossCutting</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>4.1</td>
    <td VALIGN = Middle Align = Center>Infra.Data</td>
  </tr>
      <tr>
    <td VALIGN = Middle Align = Center>4.1</td>
    <td VALIGN = Middle Align = Center>DDD.Infra.Data</td>
  </tr>
</table>


<table style="width:100%">
  <caption>Camadas 0 Presentation</caption>
  <tr>
    <th>Ordem</th>
    <th>Nome</th>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>0</td>
    <td VALIGN = Middle Align = Center>DDD.MVC</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>1</td>
    <td VALIGN = Middle Align = Center>App_Data</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>2</td>
    <td VALIGN = Middle Align = Center>App_Start</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>3</td>
    <td VALIGN = Middle Align = Center>AutoMapper</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>4</td>
    <td VALIGN = Middle Align = Center>Content</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>5</td>
    <td VALIGN = Middle Align = Center>Controller</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>6</td>
    <td VALIGN = Middle Align = Center>Fonts</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>7</td>
    <td VALIGN = Middle Align = Center>Script</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>8</td>
    <td VALIGN = Middle Align = Center>ViemModels</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>9</td>
    <td VALIGN = Middle Align = Center>Views</td>
  </tr>
</table>

<table style="width:100%">
  <caption>Camadas 3 Domain</caption>
  <tr>
    <th>Ordem</th>
    <th>Nome</th>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>0</td>
    <td VALIGN = Middle Align = Center>DDD.Domain</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>1</td>
    <td VALIGN = Middle Align = Center>Entities</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>2</td>
    <td VALIGN = Middle Align = Center>Interfaces</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>3</td>
    <td VALIGN = Middle Align = Center>Services</td>
  </tr>
</table>

<table style="width:100%">
  <caption>Camadas 4.1 Infra.Data</caption>
  <tr>
    <th>Ordem</th>
    <th>Nome</th>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>0</td>
    <td VALIGN = Middle Align = Center>DDD.Infra.Data</td>
  </tr>
    <tr>
    <td VALIGN = Middle Align = Center>1</td>
    <td VALIGN = Middle Align = Center>Context</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>2</td>
    <td VALIGN = Middle Align = Center>EntityConfig</td>
  </tr>
  <tr>
    <td VALIGN = Middle Align = Center>3</td>
    <td VALIGN = Middle Align = Center>Migrations</td>
  </tr>
  
  <tr>
    <td VALIGN = Middle Align = Center>4</td>
    <td VALIGN = Middle Align = Center>Repositories</td>
  </tr>
</table>
