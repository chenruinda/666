const  { parseDocs }  =  require ( '@electron/docs-parser' ) ;
const  fs  =  require ( 'fs' ) ;
const  path  =  require ( 'path' ) ;

const  { getElectronVersion }  =  require ( './lib/get-version' ) ;

解析文档( {
  baseDirectory：路径。解决（__dirname ， '..' ），
  包装模式：'单一' ，
  使用自述文件：假的，
  模块版本：getElectronVersion ( )
} ）。然后( ( api )  =>  {
  返回 fs 。承诺。writeFile ( path.resolve ( __dirname , ' ..' , ' electron - api.json' ) , JSON.stringify ( api , null , 2 ) ) ;     
} ）。抓住（（错误） =>  {
  控制台。错误（错误）；
  过程。退出（1 ）；
} ) ;
