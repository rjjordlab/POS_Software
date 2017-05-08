# POS/Maquina Registadora de produtos eletrónicos
-> Use o branch "Projecto" para ver o estado actual do POS_Software

Descrição (sumária) da aplicação:
  - A aplicação é uma caixa registadora que regista a compra realizada pelo cliente e que imprime o recibo da compra, e atualiza a base de dados.

Identificação e caracterização do tipo de utilizadores da aplicação:
  - Supervisor, que têm acesso a todas as funcionalidades da aplicação;
  - Empregado, que têm acesso a funcionalidades básicas da aplicação;
  - Técnico, que pode modificar a alguns aspetos da aplicação, hora/data atual, mínimo de stock, etc…

Funcionalidades:
  - Registar compra, que clientes desconhecidos e de clientes registados;
  - Atualizar base de dados dos produtos, e se houver falta de stock (numero mínimo de produtos que têm de haver em stock na loja, e que o mínimo pode ser modificado pelo técnico), poder mostrar um alerta em que é necessário reabastecer o stock especifico;
  - Poder imprimir (numa impressora real) os recibos, ou algum detalhe de um produto especifico, caso seja necessário.
  - O técnico pode inserir/remover produtos tendo a autorização do supervisor;
  - Guardar as compras numa pasta (folder) no computador;
  - Sistema de login com 3 utilizadores(supervisor, empregado, técnico).
