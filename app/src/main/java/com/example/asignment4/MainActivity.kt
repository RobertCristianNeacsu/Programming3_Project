package com.example.asignment4

import android.app.Activity
import android.content.ComponentName
import android.content.Intent
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.compose.setContent
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.tooling.preview.Preview
import com.example.asignment4.ui.theme.Asignment4Theme
import android.net.Uri
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.size
import androidx.compose.material3.Button
import androidx.compose.ui.Alignment
import androidx.compose.ui.unit.dp


class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            Asignment4Theme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colorScheme.background
                ) {
                    LauncherApp()
                }
            }
        }
    }
}

@Composable
fun LauncherApp() {
    val localContext = LocalContext.current

    var resultText by remember { mutableStateOf("") }

    val activityLauncher = rememberLauncherForActivityResult(ActivityResultContracts.StartActivityForResult()) { result ->
        // Handle the result if needed
        if (result.resultCode == Activity.RESULT_OK) {
            // Handle the result data here
            val data = result.data
            println("Received result: $data")
            resultText = data?.getStringExtra("resultData") ?: ""
        }
    }

Column(horizontalAlignment = Alignment.CenterHorizontally, verticalArrangement = Arrangement.Center) {


    val id = "User"

    Button(onClick = { /*TODO*/ }) {
    Text(
        text = "Launch Budget App",
        modifier = Modifier
            .clickable {
                val intent = Intent(Intent.ACTION_VIEW, Uri.parse("example://compose.deeplink2/?id=$id"))
                activityLauncher.launch(intent)
            },
        style = MaterialTheme.typography.headlineLarge,
    )}

    Column {
        if (resultText.isNotEmpty()) {
            Text("Result: $resultText")
        } else {
            Text("App not launched yet")
        }
    }

}

}
