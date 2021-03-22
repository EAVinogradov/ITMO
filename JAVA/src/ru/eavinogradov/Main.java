package ru.eavinogradov;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("--№1--");
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java");

        System.out.println("--№2--");
        int Result_1=(46+10)*(10/3);
        int Result_2=29*4*(-15);
        System.out.println(Result_1);
        System.out.println(Result_2);

        System.out.println("--№3--");
        int number=10500;
        int result=((number/10)/10);
        System.out.println(result);

        System.out.println("--№4--");
        float num_1=3.6f;
        float num_2=4.1f;
        float num_3=5.9f;
        float result_2=num_1*num_2*num_3;
        System.out.println(result_2);

        System.out.println("--№5--");
        Scanner textMe=new Scanner(System.in);
        System.out.println("Введите первое число:");
        int num_4=textMe.nextInt();
        System.out.println("Введите второе число:");
        int num_5=textMe.nextInt();
        System.out.println("Введите третье число:");
        int num_6=textMe.nextInt();
        System.out.println(num_4);
        System.out.println(num_5);
        System.out.println(num_6);

        System.out.println("--№6--");
        System.out.println("Введите число B:");
        int b=textMe.nextInt();
        if (b%2==0){
            System.out.println("Число B - четное");
        }
        else if (b%2!=0){
            System.out.println("Число B - нечетное");
        }
        if (b%2==0 && b>100){
            System.out.println("Выход за пределы");
        }

    }
}

