package com.example.aula01

import android.os.Bundle
import android.util.Log
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.example.aula01.databinding.ActivityMainBinding


class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.button.setOnClickListener{
            Toast.makeText(this, "Enviado", Toast.LENGTH_LONG).show()
        }

        setStatus()
        binding.checkBox.setOnCheckedChangeListener{ _, _ ->
            setStatus()
        }

        binding.radioGroup1.setOnCheckedChangeListener{ _, checkedId ->
            when(checkedId){
                binding.radioButton1.id -> {
                    Log.i("RADIOTESTE", "Opção 1")
                }
                binding.radioButton2.id -> {
                    Log.i("RADIOTESTE", "Opção 2")
                }
                binding.radioButton3.id -> {
                    Log.i("RADIOTESTE", "Opção 3")
                }
            }
        }
    }

    private fun setStatus(){
        binding.textView.text = if(binding.checkBox.isChecked){
            "Ativo"
        } else{
            "Inativo"
        }
    }
}