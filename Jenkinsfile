pipeline {
    agent any

    stages {
        stage('checkout') {
            steps {
                  checkout scm
                  powershell "git clean -fdx"
            }
        }
        stage('build') {
            steps {
                  powershell "set buildPath=%cd%"
                  powershell ""C:\\Program Files\\Unity\\Editor\Unity.exe" -quit -batchmode -logFile stdout.log -projectPath %buildPath% -executeMethod StandaloneWindowsBuild.build"
            }
        }
    }
}