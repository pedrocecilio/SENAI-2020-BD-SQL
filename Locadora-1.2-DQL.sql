USE LOCADORA

Select * From Aluguel
INNER JOIN Cliente ON (Cliente.IdCliente = Aluguel.IdCliente)
INNER JOIN Veiculo ON (Veiculo.IdVeiculo = Aluguel.IdVeiculo);