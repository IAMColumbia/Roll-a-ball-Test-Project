pipeline {
    agent any
    stages {
        stage('checkout') {
            steps {
                  checkout scm
                  powershell "'C:\\Program Files\\Git\\bin\\git.exe' clean -fdx"
            }
        }
        stage('build') {
            steps {
                  powershell "set buildPath=%cd%"
                  powershell "'C:\\Program Files\\Unity\\Editor\\Unity.exe' /quit /batchmode /executeMethod StandaloneWindowsBuild.build"
            }
        }
    }
}