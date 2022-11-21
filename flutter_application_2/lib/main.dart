import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const MaterialApp(title: 'Flutter', home: MyHomePage());
  }
}

class MyHomePage extends StatelessWidget {
  const MyHomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Flutter')), 
        body: Center(
          child: ElevatedButton(
           child: const Text('Exibir Alerta'),
           onPressed: () => showAlertDialog(context))));    

  }
}
showAlertDialog(BuildContext context) {
        //configura o button
        Widget okButton = TextButton(
          child: const Text ('OK') ,
          onPressed: () => Navigator.pop(context));
        //configura o AlertDialog
      showDialog(
        context: context,
        builder: (context) => AlertDialog(
        title: const Text('Dados'),
        content: const Text("Conteúdo da caixa"),
        actions: [okButton],  
        ));
      }