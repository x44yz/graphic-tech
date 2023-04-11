思路：  
TestRT：  
使用单独摄像机 + RenderTexture  
1.设置 camera 的 culling mask  
2.camera 渲染到 render texture  
3.将 reander texture 的材质贴到 panel 上  

TestStencil：  
RenderTexture 开销太大，采用 Stencil（注意 Render Queue 的先后）    
1.Stencil Write 写入模板缓冲  
2.Stencil Read 读取进行比较   
