import 'package:flutter/material.dart';

var corPadrao = Colors.purpleAccent;
void main() {
  runApp(MaterialApp(
      title: 'Meu primeiro Aplicativo',
      home: Scaffold(
          appBar: AppBar(
            title: const Text('Texto da barra de título'),
            backgroundColor: corPadrao),
          body: 
            const Center()
      )
  ));
}
