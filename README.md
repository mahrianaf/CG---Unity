* APLICAÇÃO UNITY: ILHA DO TESOURO
* Disciplina de Computação Gráfica

** O projeto atual tem a finalidade de criar um ambiente interativo e imersivo composto de elementos visuais 3D.
O contexto da aplicação é sobre um Capitão que atraca numa ilha para resgatar o baú do tesouro onde determina a bandeira, porém 
o baú só se torna visível quando o usuário clica no botão, entretanto, após isso a tripulação de esqueletos da ilha se prepara 
para atacar e defender o baú cobiçado, logo, cabe ao usuário disparar contra a tripulação e proteger o Capitão.
O desenvolvimento desse projeto envolveu a importação de assets para construção do tema, elaboração de scripts para atriuir 
interação e configuração da ferramenta XR Interaction Toolkit para criar a imersão através da tecnologia VR.

# Instalação Unity
- Link: https://unity.com/pt/download

# Importação de Assets
- Kit Pirata: https://quaternius.com/packs/piratekit.html
- Skybox: https://assetstore.unity.com/

# Instalação de Pacotes
- XR Hands
- XR Interaction Toolkit

# Configuração Open XR
1. Instalar XR Plugin Management em "Project Settings"
2. Localizar as abas "Desktop" e " Android" dentro do plugin instalado
   2.1 Adicionar no campo "Enabled Interaction Profiles" as opções:
     - Hand Interaction Profile
     - Meta Quest Touch Pro Controller Profile
     - Oculus Touch Controller Profile
   2.2 Setar no campo "OpenXR Feature Groups" as opções:
     - Hand Interaction Poses
     - Hand Tracking Subsystem
     - Meta Hand Tracking Aim
